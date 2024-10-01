namespace TennisScoreApp
{
    partial class PlayerInfoForm
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
            listViewVictories = new ListView();
            PlayersName = new ColumnHeader();
            Score = new ColumnHeader();
            labelVictories = new Label();
            labelPlayerName = new Label();
            listViewLosses = new ListView();
            columnHeader1 = new ColumnHeader();
            Score1 = new ColumnHeader();
            listViewDraw = new ListView();
            columnHeader2 = new ColumnHeader();
            Score2 = new ColumnHeader();
            labelLoses = new Label();
            labelDraw = new Label();
            SuspendLayout();
            // 
            // listViewVictories
            // 
            listViewVictories.BackColor = Color.Salmon;
            listViewVictories.Columns.AddRange(new ColumnHeader[] { PlayersName, Score });
            listViewVictories.Location = new Point(43, 167);
            listViewVictories.Name = "listViewVictories";
            listViewVictories.Size = new Size(239, 207);
            listViewVictories.TabIndex = 5;
            listViewVictories.UseCompatibleStateImageBehavior = false;
            listViewVictories.View = View.Details;
            // 
            // PlayersName
            // 
            PlayersName.Text = "Competitor";
            PlayersName.Width = 150;
            // 
            // Score
            // 
            Score.Text = "Score";
            Score.Width = 80;
            // 
            // labelVictories
            // 
            labelVictories.AutoSize = true;
            labelVictories.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            labelVictories.Location = new Point(43, 136);
            labelVictories.Name = "labelVictories";
            labelVictories.Size = new Size(152, 28);
            labelVictories.TabIndex = 4;
            labelVictories.Text = "Victrories";
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Unispace", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlayerName.Location = new Point(165, 24);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(437, 72);
            labelPlayerName.TabIndex = 3;
            labelPlayerName.Text = "Player Name";
            // 
            // listViewLosses
            // 
            listViewLosses.BackColor = Color.Salmon;
            listViewLosses.Columns.AddRange(new ColumnHeader[] { columnHeader1, Score1 });
            listViewLosses.Location = new Point(288, 167);
            listViewLosses.Name = "listViewLosses";
            listViewLosses.Size = new Size(242, 207);
            listViewLosses.TabIndex = 6;
            listViewLosses.UseCompatibleStateImageBehavior = false;
            listViewLosses.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Competitor";
            columnHeader1.Width = 150;
            // 
            // Score1
            // 
            Score1.Text = "Score";
            Score1.Width = 85;
            // 
            // listViewDraw
            // 
            listViewDraw.BackColor = Color.Salmon;
            listViewDraw.Columns.AddRange(new ColumnHeader[] { columnHeader2, Score2 });
            listViewDraw.Location = new Point(536, 167);
            listViewDraw.Name = "listViewDraw";
            listViewDraw.Size = new Size(243, 207);
            listViewDraw.TabIndex = 7;
            listViewDraw.UseCompatibleStateImageBehavior = false;
            listViewDraw.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Competitor";
            columnHeader2.Width = 150;
            // 
            // Score2
            // 
            Score2.Text = "Score";
            Score2.Width = 85;
            // 
            // labelLoses
            // 
            labelLoses.AutoSize = true;
            labelLoses.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            labelLoses.Location = new Point(288, 136);
            labelLoses.Name = "labelLoses";
            labelLoses.Size = new Size(96, 28);
            labelLoses.TabIndex = 8;
            labelLoses.Text = "Losses";
            // 
            // labelDraw
            // 
            labelDraw.AutoSize = true;
            labelDraw.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            labelDraw.Location = new Point(536, 136);
            labelDraw.Name = "labelDraw";
            labelDraw.Size = new Size(68, 28);
            labelDraw.TabIndex = 9;
            labelDraw.Text = "Draw";
            // 
            // PlayerInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(labelDraw);
            Controls.Add(labelLoses);
            Controls.Add(listViewDraw);
            Controls.Add(listViewLosses);
            Controls.Add(listViewVictories);
            Controls.Add(labelVictories);
            Controls.Add(labelPlayerName);
            Name = "PlayerInfoForm";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewVictories;
        private ColumnHeader PlayersName;
        private Label labelVictories;
        private Label labelPlayerName;
        private ListView listViewLosses;
        private ColumnHeader columnHeader1;
        private ListView listViewDraw;
        private ColumnHeader columnHeader2;
        private ColumnHeader Score;
        private ColumnHeader Score1;
        private Label labelLoses;
        private Label labelDraw;
        private ColumnHeader Score2;
    }
}