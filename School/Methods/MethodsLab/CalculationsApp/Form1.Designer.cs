namespace CalculationsApp
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 37);
            label1.Name = "label1";
            label1.Size = new Size(91, 14);
            label1.TabIndex = 0;
            label1.Text = "First Number";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(52, 59);
            label2.Name = "label2";
            label2.Size = new Size(105, 14);
            label2.TabIndex = 1;
            label2.Text = "Second Number:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(52, 84);
            label3.Name = "label3";
            label3.Size = new Size(70, 14);
            label3.TabIndex = 2;
            label3.Text = "Operation";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(52, 111);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 3;
            label4.Text = "Result";
            label4.Click += label4_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = SystemColors.MenuBar;
            numericUpDown1.Location = new Point(206, 29);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(131, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.BackColor = SystemColors.MenuBar;
            numericUpDown2.Location = new Point(205, 56);
            numericUpDown2.Margin = new Padding(3, 2, 3, 2);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(131, 23);
            numericUpDown2.TabIndex = 5;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Info;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "add", "subtrack", "multiply", "divide" });
            comboBox1.Location = new Point(204, 81);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 276);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Calculations app";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private ComboBox comboBox1;
    }
}