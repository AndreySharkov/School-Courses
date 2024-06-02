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
            btnRequest = new Button();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // textBoxJson
            // 
            textBoxJson.Location = new Point(33, 92);
            textBoxJson.Margin = new Padding(3, 2, 3, 2);
            textBoxJson.Multiline = true;
            textBoxJson.Name = "textBoxJson";
            textBoxJson.ReadOnly = true;
            textBoxJson.ScrollBars = ScrollBars.Vertical;
            textBoxJson.Size = new Size(350, 301);
            textBoxJson.TabIndex = 2;
            textBoxJson.TextChanged += JsonTextBoxTextChanged;
            // 
            // textBoxCsv
            // 
            textBoxCsv.Location = new Point(573, 92);
            textBoxCsv.Margin = new Padding(3, 2, 3, 2);
            textBoxCsv.Multiline = true;
            textBoxCsv.Name = "textBoxCsv";
            textBoxCsv.ReadOnly = true;
            textBoxCsv.ScrollBars = ScrollBars.Both;
            textBoxCsv.Size = new Size(350, 301);
            textBoxCsv.TabIndex = 3;
            textBoxCsv.WordWrap = false;
            textBoxCsv.TextChanged += CsvTextBoxTextChanged;
            // 
            // textBoxUserInput
            // 
            textBoxUserInput.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserInput.Location = new Point(506, 32);
            textBoxUserInput.Margin = new Padding(3, 2, 3, 2);
            textBoxUserInput.Name = "textBoxUserInput";
            textBoxUserInput.Size = new Size(176, 23);
            textBoxUserInput.TabIndex = 1;
            // 
            // labelUrl
            // 
            labelUrl.AutoSize = true;
            labelUrl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUrl.ForeColor = SystemColors.Window;
            labelUrl.Location = new Point(260, 32);
            labelUrl.Name = "labelUrl";
            labelUrl.Size = new Size(240, 21);
            labelUrl.TabIndex = 9;
            labelUrl.Text = "https://restcountries.com/v3.1/all";
            labelUrl.Click += labelUrl_Click;
            // 
            // labelEndPoints
            // 
            labelEndPoints.AutoSize = true;
            labelEndPoints.BorderStyle = BorderStyle.FixedSingle;
            labelEndPoints.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEndPoints.ForeColor = SystemColors.Window;
            labelEndPoints.Location = new Point(414, 221);
            labelEndPoints.Name = "labelEndPoints";
            labelEndPoints.Size = new Size(118, 152);
            labelEndPoints.TabIndex = 6;
            labelEndPoints.Text = "Endpoints:\r\n-name/{name}\r\n(name/peru)\r\n-region/{region}\r\n(region/europe)\r\n-subregion/{region}\r\n(subregion/europe)\r\n-capital/{capital}\r\n(capital/lima)\r\n\r\n";
            // 
            // labelJson
            // 
            labelJson.AutoSize = true;
            labelJson.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelJson.ForeColor = SystemColors.Window;
            labelJson.Location = new Point(141, 68);
            labelJson.Name = "labelJson";
            labelJson.Size = new Size(37, 15);
            labelJson.TabIndex = 7;
            labelJson.Text = "JSON";
            // 
            // labelCsv
            // 
            labelCsv.AutoSize = true;
            labelCsv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCsv.ForeColor = SystemColors.Window;
            labelCsv.Location = new Point(758, 69);
            labelCsv.Name = "labelCsv";
            labelCsv.Size = new Size(29, 15);
            labelCsv.TabIndex = 8;
            labelCsv.Text = "CSV";
            // 
            // btnRequest
            // 
            btnRequest.Location = new Point(414, 118);
            btnRequest.Margin = new Padding(3, 2, 3, 2);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(131, 38);
            btnRequest.TabIndex = 4;
            btnRequest.Text = "Request API";
            btnRequest.UseVisualStyleBackColor = true;
            btnRequest.Click += RequestButtonClick;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(414, 160);
            btnConvert.Margin = new Padding(3, 2, 3, 2);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(131, 38);
            btnConvert.TabIndex = 5;
            btnConvert.Text = "Convert to CSV";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Visible = false;
            btnConvert.Click += ConvertButtonClick;
            // 
            // JsonToCsvForm
            // 
            AcceptButton = btnRequest;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(948, 458);
            Controls.Add(btnConvert);
            Controls.Add(btnRequest);
            Controls.Add(labelCsv);
            Controls.Add(labelJson);
            Controls.Add(labelEndPoints);
            Controls.Add(labelUrl);
            Controls.Add(textBoxUserInput);
            Controls.Add(textBoxCsv);
            Controls.Add(textBoxJson);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(964, 497);
            MinimumSize = new Size(964, 497);
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
        private Button btnRequest;
        private Button btnConvert;
    }
}