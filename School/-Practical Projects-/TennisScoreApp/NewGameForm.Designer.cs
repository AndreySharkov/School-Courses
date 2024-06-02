namespace TennisScoreApp
{
    partial class NewGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Player1Label = new Label();
            Player2Label = new Label();
            textBoxFirstPlayerName = new TextBox();
            textBoxSecondPlayerName = new TextBox();
            Player1PointsLabel = new Label();
            SecondPlayerPointsLabel = new Label();
            numericUpDownFirstPlayersPoints = new NumericUpDown();
            numericUpDownSecondPlayersPoints = new NumericUpDown();
            labelVS = new Label();
            ButtonSaveGame = new Button();
            firstPlayerNameError = new ErrorProvider(components);
            secondPlayerNameError = new ErrorProvider(components);
            labelErrorMessageFirstNameTextBox = new Label();
            labelErrorMessageSecondNameTextBox = new Label();
            labelSameNamesErrorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstPlayersPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondPlayersPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)firstPlayerNameError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondPlayerNameError).BeginInit();
            SuspendLayout();
            // 
            // Player1Label
            // 
            Player1Label.AutoSize = true;
            Player1Label.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Player1Label.Location = new Point(41, 86);
            Player1Label.Name = "Player1Label";
            Player1Label.Size = new Size(104, 25);
            Player1Label.TabIndex = 0;
            Player1Label.Text = "First Player";
            // 
            // Player2Label
            // 
            Player2Label.AutoSize = true;
            Player2Label.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Player2Label.Location = new Point(398, 86);
            Player2Label.Name = "Player2Label";
            Player2Label.Size = new Size(131, 25);
            Player2Label.TabIndex = 1;
            Player2Label.Text = "Second Player";
            // 
            // textBoxFirstPlayerName
            // 
            textBoxFirstPlayerName.BackColor = Color.Salmon;
            textBoxFirstPlayerName.Location = new Point(41, 112);
            textBoxFirstPlayerName.Margin = new Padding(3, 2, 3, 2);
            textBoxFirstPlayerName.Name = "textBoxFirstPlayerName";
            textBoxFirstPlayerName.Size = new Size(210, 23);
            textBoxFirstPlayerName.TabIndex = 1;
            textBoxFirstPlayerName.Validating += ValidatePlayerName;
            // 
            // textBoxSecondPlayerName
            // 
            textBoxSecondPlayerName.BackColor = Color.Salmon;
            textBoxSecondPlayerName.Location = new Point(398, 112);
            textBoxSecondPlayerName.Margin = new Padding(3, 2, 3, 2);
            textBoxSecondPlayerName.Name = "textBoxSecondPlayerName";
            textBoxSecondPlayerName.Size = new Size(210, 23);
            textBoxSecondPlayerName.TabIndex = 2;
            textBoxSecondPlayerName.Validating += ValidatePlayerName;
            // 
            // Player1PointsLabel
            // 
            Player1PointsLabel.AutoSize = true;
            Player1PointsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Player1PointsLabel.Location = new Point(94, 174);
            Player1PointsLabel.Name = "Player1PointsLabel";
            Player1PointsLabel.Size = new Size(52, 21);
            Player1PointsLabel.TabIndex = 4;
            Player1PointsLabel.Text = "Points";
            // 
            // SecondPlayerPointsLabel
            // 
            SecondPlayerPointsLabel.AutoSize = true;
            SecondPlayerPointsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SecondPlayerPointsLabel.Location = new Point(463, 174);
            SecondPlayerPointsLabel.Name = "SecondPlayerPointsLabel";
            SecondPlayerPointsLabel.Size = new Size(52, 21);
            SecondPlayerPointsLabel.TabIndex = 5;
            SecondPlayerPointsLabel.Text = "Points";
            // 
            // numericUpDownFirstPlayersPoints
            // 
            numericUpDownFirstPlayersPoints.BackColor = Color.Salmon;
            numericUpDownFirstPlayersPoints.Location = new Point(94, 197);
            numericUpDownFirstPlayersPoints.Margin = new Padding(3, 2, 3, 2);
            numericUpDownFirstPlayersPoints.Name = "numericUpDownFirstPlayersPoints";
            numericUpDownFirstPlayersPoints.Size = new Size(57, 23);
            numericUpDownFirstPlayersPoints.TabIndex = 3;
            // 
            // numericUpDownSecondPlayersPoints
            // 
            numericUpDownSecondPlayersPoints.BackColor = Color.Salmon;
            numericUpDownSecondPlayersPoints.Location = new Point(463, 197);
            numericUpDownSecondPlayersPoints.Margin = new Padding(3, 2, 3, 2);
            numericUpDownSecondPlayersPoints.Name = "numericUpDownSecondPlayersPoints";
            numericUpDownSecondPlayersPoints.Size = new Size(57, 23);
            numericUpDownSecondPlayersPoints.TabIndex = 4;
            // 
            // labelVS
            // 
            labelVS.AutoSize = true;
            labelVS.Font = new Font("Unispace", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            labelVS.Location = new Point(282, 197);
            labelVS.Name = "labelVS";
            labelVS.Size = new Size(66, 45);
            labelVS.TabIndex = 9;
            labelVS.Text = "VS";
            // 
            // ButtonSaveGame
            // 
            ButtonSaveGame.BackColor = Color.SteelBlue;
            ButtonSaveGame.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSaveGame.ForeColor = SystemColors.ButtonFace;
            ButtonSaveGame.Location = new Point(262, 262);
            ButtonSaveGame.Margin = new Padding(3, 2, 3, 2);
            ButtonSaveGame.Name = "ButtonSaveGame";
            ButtonSaveGame.Size = new Size(108, 28);
            ButtonSaveGame.TabIndex = 5;
            ButtonSaveGame.Text = "SAVE";
            ButtonSaveGame.UseVisualStyleBackColor = false;
            ButtonSaveGame.Click += SaveGameButtonClick;
            // 
            // firstPlayerNameError
            // 
            firstPlayerNameError.ContainerControl = this;
            // 
            // secondPlayerNameError
            // 
            secondPlayerNameError.ContainerControl = this;
            // 
            // labelErrorMessageFirstNameTextBox
            // 
            labelErrorMessageFirstNameTextBox.AutoSize = true;
            labelErrorMessageFirstNameTextBox.ForeColor = Color.Red;
            labelErrorMessageFirstNameTextBox.Location = new Point(45, 134);
            labelErrorMessageFirstNameTextBox.Name = "labelErrorMessageFirstNameTextBox";
            labelErrorMessageFirstNameTextBox.Size = new Size(0, 15);
            labelErrorMessageFirstNameTextBox.TabIndex = 10;
            // 
            // labelErrorMessageSecondNameTextBox
            // 
            labelErrorMessageSecondNameTextBox.AutoSize = true;
            labelErrorMessageSecondNameTextBox.ForeColor = Color.Red;
            labelErrorMessageSecondNameTextBox.Location = new Point(398, 134);
            labelErrorMessageSecondNameTextBox.Name = "labelErrorMessageSecondNameTextBox";
            labelErrorMessageSecondNameTextBox.Size = new Size(0, 15);
            labelErrorMessageSecondNameTextBox.TabIndex = 11;
            // 
            // labelSameNamesErrorMessage
            // 
            labelSameNamesErrorMessage.AutoSize = true;
            labelSameNamesErrorMessage.ForeColor = Color.Red;
            labelSameNamesErrorMessage.Location = new Point(209, 159);
            labelSameNamesErrorMessage.Name = "labelSameNamesErrorMessage";
            labelSameNamesErrorMessage.Size = new Size(0, 15);
            labelSameNamesErrorMessage.TabIndex = 12;
            // 
            // NewGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(700, 338);
            Controls.Add(labelSameNamesErrorMessage);
            Controls.Add(labelErrorMessageSecondNameTextBox);
            Controls.Add(labelErrorMessageFirstNameTextBox);
            Controls.Add(ButtonSaveGame);
            Controls.Add(labelVS);
            Controls.Add(numericUpDownSecondPlayersPoints);
            Controls.Add(numericUpDownFirstPlayersPoints);
            Controls.Add(SecondPlayerPointsLabel);
            Controls.Add(Player1PointsLabel);
            Controls.Add(textBoxSecondPlayerName);
            Controls.Add(textBoxFirstPlayerName);
            Controls.Add(Player2Label);
            Controls.Add(Player1Label);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NewGameForm";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstPlayersPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondPlayersPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)firstPlayerNameError).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondPlayerNameError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Player1Label;
        private Label Player2Label;
        private TextBox textBoxFirstPlayerName;
        private TextBox textBoxSecondPlayerName;
        private Label Player1PointsLabel;
        private Label SecondPlayerPointsLabel;
        private NumericUpDown numericUpDownFirstPlayersPoints;
        private NumericUpDown numericUpDownSecondPlayersPoints;
        private Label labelVS;
        private Button ButtonSaveGame;
        private ErrorProvider firstPlayerNameError;
        private ErrorProvider secondPlayerNameError;
        private Label labelErrorMessageFirstNameTextBox;
        private Label labelErrorMessageSecondNameTextBox;
        private Label labelSameNamesErrorMessage;
    }
}