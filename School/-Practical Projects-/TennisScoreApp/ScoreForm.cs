using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace TennisScoreApp
{
    public partial class MainTennisForm : Form
    {
        private static Dictionary<string, int> playersWithPoints = new();
        private static Dictionary<(string, int), List<(string, int)>> games 
            = new Dictionary<(string, int), List<(string, int)>>();
        private void OnLoad(object sender, EventArgs e)
        {
            FillRankingListView();
            FillLatestGamesListView();
        }
        private void FillRankingListView()
        {
            this.listViewRanking.Items.Clear();
            foreach (var player in playersWithPoints.OrderByDescending(x => x.Value))
            {
                string playerName = player.Key;
                string playerPoints = player.Value.ToString();
                ListViewItem rollInRankingListView = new();
                rollInRankingListView.SubItems[0].Text = playerName;
                rollInRankingListView.SubItems.Add(playerPoints);
                this.listViewRanking.Items.Add(rollInRankingListView);
            }

        }
        private void FillLatestGamesListView()
        {
            this.listViewLastestGames.Items.Clear();
            foreach (var game in games.Reverse())
            {
                foreach (var item in game.Value)
                {
                    FillListView(game.Key, item);
                }
            }
        }
        private void FillListView((string, int) firstPlayer, (string, int) secondPlayer)
        {
            string winner = GetWinner(firstPlayer, secondPlayer);
            ListViewItem rollinLastestGamesListView = new ListViewItem();
            rollinLastestGamesListView.SubItems[0].Text = firstPlayer.Item1;
            rollinLastestGamesListView.SubItems.Add(secondPlayer.Item1);
            rollinLastestGamesListView.SubItems.Add(winner);
            rollinLastestGamesListView.SubItems.Add($"{firstPlayer.Item2} - {secondPlayer.Item2}");
            this.listViewLastestGames.Items.Add(rollinLastestGamesListView);
        }
        private string GetWinner((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (firstPlayer.Item2 > secondPlayer.Item2)
            {
                return firstPlayer.Item1;
            }
            else if (firstPlayer.Item2 < secondPlayer.Item2)
            {
                return secondPlayer.Item1;
            }
            else
            {
                return "Draw";
            }
        }


        
        public MainTennisForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // add new game
        {
            using (NewGameForm newGameForm = new NewGameForm())
            {
                if (newGameForm.ShowDialog() == DialogResult.OK)
                {
                    AddNewGame(newGameForm.FirstPlayer, newGameForm.SecondPlayer);
                }
            }
        }
        private void AddNewGame((string, int) firstPlayer, (string, int) secondPlayer)
        {
            FillGamesData(firstPlayer, secondPlayer);
            FillPlayerWithPoints(firstPlayer);
            FillPlayerWithPoints(secondPlayer);
            FillRankingListView();
            FillLatestGamesListView();
        }
        private void FillPlayerWithPoints((string, int)player)
        {
            if (playersWithPoints.ContainsKey(player.Item1))
            {
                playersWithPoints[player.Item1] += player.Item2;
            }
            else
            {
                playersWithPoints.Add(player.Item1, player.Item2);
            }
        }

        private void FillGamesData((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (games.ContainsKey(firstPlayer))
            {
                games[firstPlayer].Add(secondPlayer);
            }
            else if (games.ContainsKey(secondPlayer))
            {
                games[secondPlayer].Add(firstPlayer);
            }
            else
            {
                games.Add(firstPlayer, new List<(string, int)> { secondPlayer });
            }
        }
        private void ViewProfileButtonClick(object sender, EventArgs e)
        {
            ListViewItem selectedRow = this.listViewRanking.SelectedItems[0];
            ListViewSubItem playerNameCell = selectedRow.SubItems[0];
            string playerName = playerNameCell.Text;
            using (PlayerInfoForm playerInfoForm = new PlayerInfoForm
                (playerName, GetPlayerGames(playerName)))
            {
                playerInfoForm.ShowDialog();
            }
        }
        private Dictionary<(string, int), List<(string, int)>> GetPlayerGames
             (string playerName) => games.Where(x => x.Key.Item1 == playerName || x.Value.Any(y => y.Item1 == playerName))
                     .ToDictionary(x => x.Key, x => x.Value.Where(y => y.Item1 == playerName|| x.Key.Item1 == playerName)
                     .ToList());


    }
}