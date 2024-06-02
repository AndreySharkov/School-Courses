using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace TennisScoreApp
{
    public partial class PlayerInfoForm : Form
    {
        private string playerName;
        private Dictionary<(string, int), List<(string, int)>> games = new();
        private (string, int) currentPlayer = new();
        private (string, int) competitor = new();

        public PlayerInfoForm(string playerName, Dictionary<(string, int), List<(string, int)>> games)
        {
            InitializeComponent();
            this.games = games;
            this.playerName = playerName;
            this.labelPlayerName.Text = playerName;
            FillVictoriesAndLossesListViews();
        }
        private void FillVictoriesAndLossesListViews()
        {
            ClearListViews();
            foreach (var game in games)
            {
                string firstPlayerName = game.Key.Item1;
                int firstPlayerPoints = game.Key.Item2;
                foreach (var item in game.Value)
                {
                    string secondPlayerName = item.Item1;
                    int secondPlayerPoints = item.Item2;
                    (this.currentPlayer, this.competitor) = 
                    GetCurrentPlayerAndCompetitor((firstPlayerName, firstPlayerPoints), (secondPlayerName, secondPlayerPoints)); 
                    UpdateListView();
                }  
            }
        }
        private void ClearListViews()
        {
            this.listViewDraw.Items.Clear();
            this.listViewLosses.Items.Clear();
            this.listViewVictories.Items.Clear();
        }

        private ((string, int), (string, int)) GetCurrentPlayerAndCompetitor
            ((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (firstPlayer.Item1 == playerName)
            { 
                return (firstPlayer, secondPlayer);
            }
            return (secondPlayer, firstPlayer);
        }
        private void UpdateListView()
        {
            string competitorName = competitor.Item1;
            int currentPlayerPoints = currentPlayer.Item2;
            int competitorPoints = competitor.Item2;
            string score = $"{currentPlayerPoints} - {competitorPoints}";
            ListView currentListView = GetCurrentListView(currentPlayerPoints, competitorPoints);
            AddDataToListView(competitorName, score, currentListView);
        }
        private ListView GetCurrentListView(int currentPlayerPoints, int competitorPoints)
        {
            if(currentPlayerPoints > competitorPoints)
            {
                return this.listViewVictories;
            }
            else if(currentPlayerPoints < competitorPoints)
            {
                return this.listViewLosses;
            }
            return this.listViewDraw;
        }
        private void AddDataToListView(string competitor, string score, ListView listView)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.SubItems[0].Text = competitor;
            listViewItem.SubItems.Add(score);
            listView.Items.Add(listViewItem);
        }






        public PlayerInfoForm()
        {
            InitializeComponent();
        }
    }
}
