namespace TennisScoreApp
{
    partial class MainTennisForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TennisScoreLabel = new Label();
            label1 = new Label();
            listViewRanking = new ListView();
            PlayersName = new ColumnHeader();
            Score = new ColumnHeader();
            listViewLastestGames = new ListView();
            firstPlayer = new ColumnHeader();
            SecondPlayer = new ColumnHeader();
            Winner = new ColumnHeader();
            PlayerScore = new ColumnHeader();
            label2 = new Label();
            label3 = new Label();
            AddNewGameButton = new Button();
            SuspendLayout();
            // 
            // TennisScoreLabel
            // 
            TennisScoreLabel.AutoSize = true;
            TennisScoreLabel.Font = new Font("Unispace", 36F, FontStyle.Bold, GraphicsUnit.Point);
            TennisScoreLabel.Location = new Point(131, 21);
            TennisScoreLabel.Name = "TennisScoreLabel";
            TennisScoreLabel.Size = new Size(373, 58);
            TennisScoreLabel.TabIndex = 0;
            TennisScoreLabel.Text = "Tennis Score";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 70);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 1;
            label1.Text = "Ranking";
            // 
            // listViewRanking
            // 
            listViewRanking.BackColor = Color.Bisque;
            listViewRanking.Columns.AddRange(new ColumnHeader[] { PlayersName, Score });
            listViewRanking.Location = new Point(46, 93);
            listViewRanking.Margin = new Padding(3, 2, 3, 2);
            listViewRanking.Name = "listViewRanking";
            listViewRanking.Size = new Size(589, 92);
            listViewRanking.TabIndex = 2;
            listViewRanking.UseCompatibleStateImageBehavior = false;
            listViewRanking.View = View.Details;
            listViewRanking.Click += ViewProfileButtonClick;
            // 
            // PlayersName
            // 
            PlayersName.Text = "Player Name";
            PlayersName.Width = 340;
            // 
            // Score
            // 
            Score.Text = "Score";
            Score.Width = 300;
            // 
            // listViewLastestGames
            // 
            listViewLastestGames.BackColor = Color.Bisque;
            listViewLastestGames.Columns.AddRange(new ColumnHeader[] { firstPlayer, SecondPlayer, Winner, PlayerScore });
            listViewLastestGames.Location = new Point(46, 224);
            listViewLastestGames.Margin = new Padding(3, 2, 3, 2);
            listViewLastestGames.Name = "listViewLastestGames";
            listViewLastestGames.Size = new Size(589, 92);
            listViewLastestGames.TabIndex = 4;
            listViewLastestGames.UseCompatibleStateImageBehavior = false;
            listViewLastestGames.View = View.Details;
            // 
            // firstPlayer
            // 
            firstPlayer.Text = "First Player";
            firstPlayer.Width = 170;
            // 
            // SecondPlayer
            // 
            SecondPlayer.Text = "SecondPlayer";
            SecondPlayer.Width = 170;
            // 
            // Winner
            // 
            Winner.Text = "Winner";
            Winner.Width = 150;
            // 
            // PlayerScore
            // 
            PlayerScore.Text = "Score";
            PlayerScore.Width = 95;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 201);
            label2.Name = "label2";
            label2.Size = new Size(154, 23);
            label2.TabIndex = 3;
            label2.Text = "Latest Games";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Unispace", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(46, 186);
            label3.Name = "label3";
            label3.Size = new Size(483, 14);
            label3.TabIndex = 5;
            label3.Text = "*click on a players name to see more information about their matches";
            // 
            // AddNewGameButton
            // 
            AddNewGameButton.Location = new Point(470, 201);
            AddNewGameButton.Margin = new Padding(3, 2, 3, 2);
            AddNewGameButton.Name = "AddNewGameButton";
            AddNewGameButton.Size = new Size(165, 22);
            AddNewGameButton.TabIndex = 6;
            AddNewGameButton.Text = "Add New Game";
            AddNewGameButton.UseVisualStyleBackColor = true;
            AddNewGameButton.Click += button1_Click;
            // 
            // MainTennisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(700, 338);
            Controls.Add(AddNewGameButton);
            Controls.Add(label3);
            Controls.Add(listViewLastestGames);
            Controls.Add(label2);
            Controls.Add(listViewRanking);
            Controls.Add(label1);
            Controls.Add(TennisScoreLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainTennisForm";
            Text = "TennisScoreApp";
            Load += OnLoad;
            ResumeLayout(false);
            PerformLayout();
        }






        #endregion

        private Label TennisScoreLabel;
        private Label label1;
        private ListView listViewRanking;
        private ColumnHeader PlayersName;
        private ColumnHeader Score;
        private ListView listViewLastestGames;
        private ColumnHeader firstPlayer;
        private ColumnHeader SecondPlayer;
        private Label label2;
        private Label label3;
        private Button AddNewGameButton;
        private ColumnHeader Winner;
        private ColumnHeader PlayerScore;
    }
}