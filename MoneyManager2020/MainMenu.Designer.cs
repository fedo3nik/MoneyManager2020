namespace MoneyManager2020
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.MainMenuLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.LastIncomeLabel = new System.Windows.Forms.Label();
            this.LastOutlayLabel = new System.Windows.Forms.Label();
            this.IncomeButton = new System.Windows.Forms.Button();
            this.OutlayButton = new System.Windows.Forms.Button();
            this.EditPlanButton = new System.Windows.Forms.Button();
            this.SetIncomesOutlaysButton = new System.Windows.Forms.Button();
            this.DataGridViewPlan = new System.Windows.Forms.DataGridView();
            this.CashLabel = new System.Windows.Forms.Label();
            this.DollarLabel = new System.Windows.Forms.Label();
            this.dataBaseUML = new MoneyManager2020.DataBaseUML();
            this.outlayPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outlayPlanTableAdapter = new MoneyManager2020.DataBaseUMLTableAdapters.OutlayPlanTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IncomeDateLabel = new System.Windows.Forms.Label();
            this.OutlayDateLabel = new System.Windows.Forms.Label();
            this.IncomeTextLabel = new System.Windows.Forms.Label();
            this.OutlayTextLabel = new System.Windows.Forms.Label();
            this.OutlayPlanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseUML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outlayPlanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuLabel
            // 
            this.MainMenuLabel.AutoSize = true;
            this.MainMenuLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainMenuLabel.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuLabel.ForeColor = System.Drawing.Color.Coral;
            this.MainMenuLabel.Location = new System.Drawing.Point(12, 9);
            this.MainMenuLabel.Name = "MainMenuLabel";
            this.MainMenuLabel.Size = new System.Drawing.Size(240, 32);
            this.MainMenuLabel.TabIndex = 1;
            this.MainMenuLabel.Text = "MoneyManger2020";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.emailLabel.Location = new System.Drawing.Point(13, 45);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(101, 25);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "user email";
            // 
            // LastIncomeLabel
            // 
            this.LastIncomeLabel.AutoSize = true;
            this.LastIncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastIncomeLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.LastIncomeLabel.Location = new System.Drawing.Point(7, 97);
            this.LastIncomeLabel.Name = "LastIncomeLabel";
            this.LastIncomeLabel.Size = new System.Drawing.Size(24, 25);
            this.LastIncomeLabel.TabIndex = 3;
            this.LastIncomeLabel.Text = "0";
            // 
            // LastOutlayLabel
            // 
            this.LastOutlayLabel.AutoSize = true;
            this.LastOutlayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastOutlayLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.LastOutlayLabel.Location = new System.Drawing.Point(7, 160);
            this.LastOutlayLabel.Name = "LastOutlayLabel";
            this.LastOutlayLabel.Size = new System.Drawing.Size(24, 25);
            this.LastOutlayLabel.TabIndex = 4;
            this.LastOutlayLabel.Text = "0";
            // 
            // IncomeButton
            // 
            this.IncomeButton.BackColor = System.Drawing.Color.DarkCyan;
            this.IncomeButton.Location = new System.Drawing.Point(12, 259);
            this.IncomeButton.Name = "IncomeButton";
            this.IncomeButton.Size = new System.Drawing.Size(121, 56);
            this.IncomeButton.TabIndex = 5;
            this.IncomeButton.Text = "Add Income";
            this.IncomeButton.UseVisualStyleBackColor = false;
            this.IncomeButton.Click += new System.EventHandler(this.IncomeButton_Click);
            // 
            // OutlayButton
            // 
            this.OutlayButton.BackColor = System.Drawing.Color.DarkCyan;
            this.OutlayButton.Location = new System.Drawing.Point(139, 259);
            this.OutlayButton.Name = "OutlayButton";
            this.OutlayButton.Size = new System.Drawing.Size(121, 56);
            this.OutlayButton.TabIndex = 6;
            this.OutlayButton.Text = "Add Outlay";
            this.OutlayButton.UseVisualStyleBackColor = false;
            this.OutlayButton.Click += new System.EventHandler(this.OutlayButton_Click);
            // 
            // EditPlanButton
            // 
            this.EditPlanButton.BackColor = System.Drawing.Color.DarkCyan;
            this.EditPlanButton.Location = new System.Drawing.Point(554, 259);
            this.EditPlanButton.Name = "EditPlanButton";
            this.EditPlanButton.Size = new System.Drawing.Size(121, 56);
            this.EditPlanButton.TabIndex = 7;
            this.EditPlanButton.Text = "Edit your outlay plan";
            this.EditPlanButton.UseVisualStyleBackColor = false;
            this.EditPlanButton.Click += new System.EventHandler(this.EditPlanButton_Click);
            // 
            // SetIncomesOutlaysButton
            // 
            this.SetIncomesOutlaysButton.BackColor = System.Drawing.Color.DarkCyan;
            this.SetIncomesOutlaysButton.Location = new System.Drawing.Point(320, 259);
            this.SetIncomesOutlaysButton.Name = "SetIncomesOutlaysButton";
            this.SetIncomesOutlaysButton.Size = new System.Drawing.Size(121, 56);
            this.SetIncomesOutlaysButton.TabIndex = 8;
            this.SetIncomesOutlaysButton.Text = "Set new Outlays or Incomes";
            this.SetIncomesOutlaysButton.UseVisualStyleBackColor = false;
            this.SetIncomesOutlaysButton.Click += new System.EventHandler(this.SetIncomesOutlaysButton_Click);
            // 
            // DataGridViewPlan
            // 
            this.DataGridViewPlan.BackgroundColor = System.Drawing.Color.Aqua;
            this.DataGridViewPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPlan.Location = new System.Drawing.Point(320, 45);
            this.DataGridViewPlan.Name = "DataGridViewPlan";
            this.DataGridViewPlan.RowHeadersWidth = 51;
            this.DataGridViewPlan.RowTemplate.Height = 24;
            this.DataGridViewPlan.Size = new System.Drawing.Size(351, 208);
            this.DataGridViewPlan.TabIndex = 9;
            // 
            // CashLabel
            // 
            this.CashLabel.AutoSize = true;
            this.CashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CashLabel.ForeColor = System.Drawing.Color.Orange;
            this.CashLabel.Location = new System.Drawing.Point(143, 45);
            this.CashLabel.Name = "CashLabel";
            this.CashLabel.Size = new System.Drawing.Size(50, 25);
            this.CashLabel.TabIndex = 10;
            this.CashLabel.Text = "zero";
            this.CashLabel.Click += new System.EventHandler(this.CashLabel_Click);
            // 
            // DollarLabel
            // 
            this.DollarLabel.AutoSize = true;
            this.DollarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DollarLabel.ForeColor = System.Drawing.Color.Orange;
            this.DollarLabel.Location = new System.Drawing.Point(258, 45);
            this.DollarLabel.Name = "DollarLabel";
            this.DollarLabel.Size = new System.Drawing.Size(23, 25);
            this.DollarLabel.TabIndex = 11;
            this.DollarLabel.Text = "$";
            // 
            // dataBaseUML
            // 
            this.dataBaseUML.DataSetName = "DataBaseUML";
            this.dataBaseUML.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // outlayPlanBindingSource
            // 
            this.outlayPlanBindingSource.DataMember = "OutlayPlan";
            this.outlayPlanBindingSource.DataSource = this.dataBaseUML;
            // 
            // outlayPlanTableAdapter
            // 
            this.outlayPlanTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(64, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(64, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "$";
            // 
            // IncomeDateLabel
            // 
            this.IncomeDateLabel.AutoSize = true;
            this.IncomeDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncomeDateLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.IncomeDateLabel.Location = new System.Drawing.Point(91, 97);
            this.IncomeDateLabel.Name = "IncomeDateLabel";
            this.IncomeDateLabel.Size = new System.Drawing.Size(23, 25);
            this.IncomeDateLabel.TabIndex = 14;
            this.IncomeDateLabel.Text = "d";
            this.IncomeDateLabel.Click += new System.EventHandler(this.IncomeDateLabel_Click);
            // 
            // OutlayDateLabel
            // 
            this.OutlayDateLabel.AutoSize = true;
            this.OutlayDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutlayDateLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.OutlayDateLabel.Location = new System.Drawing.Point(91, 160);
            this.OutlayDateLabel.Name = "OutlayDateLabel";
            this.OutlayDateLabel.Size = new System.Drawing.Size(23, 25);
            this.OutlayDateLabel.TabIndex = 15;
            this.OutlayDateLabel.Text = "d";
            // 
            // IncomeTextLabel
            // 
            this.IncomeTextLabel.AutoSize = true;
            this.IncomeTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncomeTextLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.IncomeTextLabel.Location = new System.Drawing.Point(197, 97);
            this.IncomeTextLabel.Name = "IncomeTextLabel";
            this.IncomeTextLabel.Size = new System.Drawing.Size(117, 25);
            this.IncomeTextLabel.TabIndex = 16;
            this.IncomeTextLabel.Text = "Last income";
            // 
            // OutlayTextLabel
            // 
            this.OutlayTextLabel.AutoSize = true;
            this.OutlayTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutlayTextLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.OutlayTextLabel.Location = new System.Drawing.Point(197, 160);
            this.OutlayTextLabel.Name = "OutlayTextLabel";
            this.OutlayTextLabel.Size = new System.Drawing.Size(106, 25);
            this.OutlayTextLabel.TabIndex = 17;
            this.OutlayTextLabel.Text = "Last outlay";
            // 
            // OutlayPlanLabel
            // 
            this.OutlayPlanLabel.AutoSize = true;
            this.OutlayPlanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutlayPlanLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.OutlayPlanLabel.Location = new System.Drawing.Point(315, 17);
            this.OutlayPlanLabel.Name = "OutlayPlanLabel";
            this.OutlayPlanLabel.Size = new System.Drawing.Size(152, 25);
            this.OutlayPlanLabel.TabIndex = 18;
            this.OutlayPlanLabel.Text = "Your outlay plan";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(687, 329);
            this.Controls.Add(this.OutlayPlanLabel);
            this.Controls.Add(this.OutlayTextLabel);
            this.Controls.Add(this.IncomeTextLabel);
            this.Controls.Add(this.OutlayDateLabel);
            this.Controls.Add(this.IncomeDateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DollarLabel);
            this.Controls.Add(this.CashLabel);
            this.Controls.Add(this.DataGridViewPlan);
            this.Controls.Add(this.SetIncomesOutlaysButton);
            this.Controls.Add(this.EditPlanButton);
            this.Controls.Add(this.OutlayButton);
            this.Controls.Add(this.IncomeButton);
            this.Controls.Add(this.LastOutlayLabel);
            this.Controls.Add(this.LastIncomeLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.MainMenuLabel);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseUML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outlayPlanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainMenuLabel;
        private System.Windows.Forms.Button IncomeButton;
        private System.Windows.Forms.Button OutlayButton;
        private System.Windows.Forms.Button EditPlanButton;
        private System.Windows.Forms.Button SetIncomesOutlaysButton;
        public System.Windows.Forms.Label emailLabel;
        public System.Windows.Forms.Label CashLabel;
        public System.Windows.Forms.Label DollarLabel;
        private DataBaseUML dataBaseUML;
        private System.Windows.Forms.BindingSource outlayPlanBindingSource;
        private DataBaseUMLTableAdapters.OutlayPlanTableAdapter outlayPlanTableAdapter;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label IncomeDateLabel;
        public System.Windows.Forms.Label OutlayDateLabel;
        public System.Windows.Forms.Label IncomeTextLabel;
        public System.Windows.Forms.Label OutlayTextLabel;
        public System.Windows.Forms.DataGridView DataGridViewPlan;
        public System.Windows.Forms.Label LastIncomeLabel;
        public System.Windows.Forms.Label LastOutlayLabel;
        public System.Windows.Forms.Label OutlayPlanLabel;
    }
}