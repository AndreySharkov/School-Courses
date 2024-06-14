namespace JSONtoCSV
{
    partial class JsonToCsvForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JsonToCsvForm));
            textBoxJson = new TextBox();
            textBoxCsv = new TextBox();
            textBoxUserInput = new TextBox();
            labelUrl = new Label();
            labelEndPoints = new Label();
            labelJson = new Label();
            labelCsv = new Label();
            btnRequestAPI = new Button();
            btnConvertToCsv = new Button();
            SuspendLayout();
            // 
            // textBoxJson
            // 
            textBoxJson.BackColor = Color.LightGray;
            textBoxJson.Location = new Point(34, 123);
            textBoxJson.Multiline = true;
            textBoxJson.Name = "textBoxJson";
            textBoxJson.ReadOnly = true;
            textBoxJson.ScrollBars = ScrollBars.Vertical;
            textBoxJson.Size = new Size(400, 400);
            textBoxJson.TabIndex = 2;
            textBoxJson.TextChanged += JsonTextBoxTextChanged;
            // 
            // textBoxCsv
            // 
            textBoxCsv.BackColor = Color.LightGray;
            textBoxCsv.Location = new Point(655, 123);
            textBoxCsv.Multiline = true;
            textBoxCsv.Name = "textBoxCsv";
            textBoxCsv.ReadOnly = true;
            textBoxCsv.ScrollBars = ScrollBars.Both;
            textBoxCsv.Size = new Size(400, 400);
            textBoxCsv.TabIndex = 3;
            textBoxCsv.WordWrap = false;
            textBoxCsv.TextChanged += CsvTextBoxTextChanged;
            // 
            // textBoxUserInput
            // 
            textBoxUserInput.BackColor = Color.LightGray;
            textBoxUserInput.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserInput.Location = new Point(560, 47);
            textBoxUserInput.Name = "textBoxUserInput";
            textBoxUserInput.Size = new Size(200, 27);
            textBoxUserInput.TabIndex = 1;
            // 
            // labelUrl
            // 
            labelUrl.AutoSize = true;
            labelUrl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUrl.ForeColor = SystemColors.Window;
            labelUrl.Location = new Point(307, 46);
            labelUrl.Name = "labelUrl";
            labelUrl.Size = new Size(247, 28);
            labelUrl.TabIndex = 9;
            labelUrl.Text = "https://api.zippopotam.us/";
            // 
            // labelEndPoints
            // 
            labelEndPoints.AutoSize = true;
            labelEndPoints.BorderStyle = BorderStyle.FixedSingle;
            labelEndPoints.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEndPoints.ForeColor = SystemColors.Window;
            labelEndPoints.Location = new Point(473, 295);
            labelEndPoints.Name = "labelEndPoints";
            labelEndPoints.Size = new Size(165, 102);
            labelEndPoints.TabIndex = 6;
            labelEndPoints.Text = "Endpoints:\r\n- country/postal-code\r\n (us/90210)\r\n- country/state/city\r\n (us/ma/belmont)\r\n";
            // 
            // labelJson
            // 
            labelJson.AutoSize = true;
            labelJson.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelJson.ForeColor = SystemColors.Window;
            labelJson.Location = new Point(34, 100);
            labelJson.Name = "labelJson";
            labelJson.Size = new Size(47, 20);
            labelJson.TabIndex = 7;
            labelJson.Text = "JSON";
            // 
            // labelCsv
            // 
            labelCsv.AutoSize = true;
            labelCsv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCsv.ForeColor = SystemColors.Window;
            labelCsv.Location = new Point(655, 100);
            labelCsv.Name = "labelCsv";
            labelCsv.Size = new Size(36, 20);
            labelCsv.TabIndex = 8;
            labelCsv.Text = "CSV";
            // 
            // btnRequestAPI
            // 
            btnRequestAPI.Location = new Point(473, 158);
            btnRequestAPI.Name = "btnRequestAPI";
            btnRequestAPI.Size = new Size(150, 50);
            btnRequestAPI.TabIndex = 4;
            btnRequestAPI.Text = "Request API";
            btnRequestAPI.UseVisualStyleBackColor = true;
            btnRequestAPI.Click += RequestButtonClick;
            // 
            // btnConvertToCsv
            // 
            btnConvertToCsv.Location = new Point(473, 214);
            btnConvertToCsv.Name = "btnConvertToCsv";
            btnConvertToCsv.Size = new Size(150, 50);
            btnConvertToCsv.TabIndex = 5;
            btnConvertToCsv.Text = "Convert to CSV";
            btnConvertToCsv.UseVisualStyleBackColor = true;
            btnConvertToCsv.Visible = false;
            btnConvertToCsv.Click += ConvertButtonClick;
            // 
            // JsonToCsvForm
            // 
            AcceptButton = btnRequestAPI;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1082, 603);
            Controls.Add(btnConvertToCsv);
            Controls.Add(btnRequestAPI);
            Controls.Add(labelCsv);
            Controls.Add(labelJson);
            Controls.Add(labelEndPoints);
            Controls.Add(labelUrl);
            Controls.Add(textBoxUserInput);
            Controls.Add(textBoxCsv);
            Controls.Add(textBoxJson);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1100, 650);
            MinimumSize = new Size(1100, 650);
            Name = "JsonToCsvForm";
            Text = "JsonToCsv";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxJson;
        private TextBox textBoxCsv;
        private TextBox textBoxUserInput;
        private Label labelUrl;
        private Label labelEndPoints;
        private Label labelJson;
        private Label labelCsv;
        private Button btnRequestAPI;
        private Button btnConvertToCsv;
    }
}