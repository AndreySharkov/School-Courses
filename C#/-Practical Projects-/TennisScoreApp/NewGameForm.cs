using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace TennisScoreApp
{
    public partial class NewGameForm : Form
    {
        public NewGameForm()
        {
            InitializeComponent();
        }
        public (string, int) FirstPlayer { get; set; }
        public (string, int) SecondPlayer { get; set; }
        
        private void SaveGameButtonClick(object sender, EventArgs e)
        {
            string firstPlayerName = textBoxFirstPlayerName.Text.Trim();
            string secondPlayerName = textBoxSecondPlayerName.Text.Trim();
            int firstPlayerPoints = (int)numericUpDownFirstPlayersPoints.Value;
            int secondPlayerPoints = (int)numericUpDownSecondPlayersPoints.Value;

            FirstPlayer = (firstPlayerName, firstPlayerPoints);
            SecondPlayer = (secondPlayerName, secondPlayerPoints);

            if (!CheckIfInputsAreValid())
            {
                ValidateChildren(ValidationConstraints.Enabled);
                return;
            }

            this.DialogResult = DialogResult.OK;

        }
        private bool CheckIfInputsAreValid()
            => !CheckIfPlayerNamesAreEmpty() && !CheckIfPlayerNamesAreSame();
        private bool CheckIfPlayerNamesAreEmpty()
            => string.IsNullOrEmpty(FirstPlayer.Item1) || string.IsNullOrEmpty(SecondPlayer.Item1);
        private bool CheckIfPlayerNamesAreSame()
            => FirstPlayer.Item1 == SecondPlayer.Item1;
        private void ValidatePlayerName(object sender, CancelEventArgs e)
        {
            string firstPlayerName = textBoxFirstPlayerName.Text.Trim();
            string secondPlayerName = textBoxSecondPlayerName.Text.Trim();
            int firstPlayerPoints = (int)numericUpDownFirstPlayersPoints.Value;
            int secondPlayerPoints = (int)numericUpDownSecondPlayersPoints.Value;
            
            FirstPlayer = (firstPlayerName, firstPlayerPoints);
            SecondPlayer = (secondPlayerName, secondPlayerPoints);
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                ShowEmptyNameErrorMessage(textBox);
            }
            else
            {
                e.Cancel = false;
                RemoveErrorMessages(textBox);
                ShowErrorOnSameNames();
            }
        }
        private void ShowEmptyNameErrorMessage(TextBox textBox)
        {
            var errorText = "Player Name should not be left blank!";
            if (textBox == this.textBoxFirstPlayerName)
            {
                this.firstPlayerNameError.SetError(textBox, errorText);
                this.labelErrorMessageFirstNameTextBox.Text = "First" + errorText;
            }
            if (textBox == this.textBoxSecondPlayerName)
            {
                this.secondPlayerNameError.SetError(textBox, errorText);
                this.labelErrorMessageSecondNameTextBox.Text = "Second" + errorText;
            }
        }
        private void RemoveErrorMessages(TextBox textBox)
        {
            if (textBox == this.textBoxFirstPlayerName)
            {
                this.firstPlayerNameError.SetError(textBox, "");
                this.labelErrorMessageFirstNameTextBox.Text = string.Empty;
            }
            else if (textBox == this.textBoxSecondPlayerName)
            {
                this.secondPlayerNameError.SetError(textBox, "");
                this.labelErrorMessageSecondNameTextBox.Text = string.Empty;
            }
        }
        private void ShowErrorOnSameNames()
        {
            if (CheckIfPlayerNamesAreSame())
            {
                this.labelSameNamesErrorMessage.Text = "First Player name should not be same as Second Player name!";
            }
            else
            {
                this.labelSameNamesErrorMessage.Text = string.Empty;
            }

        }

        private void Player1PointsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
