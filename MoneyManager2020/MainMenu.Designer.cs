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
            this.MainMenuLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.LastIncomeLabel = new System.Windows.Forms.Label();
            this.LastOtlayLabel = new System.Windows.Forms.Label();
            this.IncomeButton = new System.Windows.Forms.Button();
            this.OutlayButton = new System.Windows.Forms.Button();
            this.EditPlanButton = new System.Windows.Forms.Button();
            this.SetIncomesOutlaysButton = new System.Windows.Forms.Button();
            this.DataGridViewPlan = new System.Windows.Forms.DataGridView();
            this.CashLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPlan)).BeginInit();
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
            this.LastIncomeLabel.Location = new System.Drawing.Point(13, 97);
            this.LastIncomeLabel.Name = "LastIncomeLabel";
            this.LastIncomeLabel.Size = new System.Drawing.Size(24, 25);
            this.LastIncomeLabel.TabIndex = 3;
            this.LastIncomeLabel.Text = "0";
            // 
            // LastOtlayLabel
            // 
            this.LastOtlayLabel.AutoSize = true;
            this.LastOtlayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastOtlayLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.LastOtlayLabel.Location = new System.Drawing.Point(13, 160);
            this.LastOtlayLabel.Name = "LastOtlayLabel";
            this.LastOtlayLabel.Size = new System.Drawing.Size(24, 25);
            this.LastOtlayLabel.TabIndex = 4;
            this.LastOtlayLabel.Text = "0";
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
            // 
            // SetIncomesOutlaysButton
            // 
            this.SetIncomesOutlaysButton.BackColor = System.Drawing.Color.DarkCyan;
            this.SetIncomesOutlaysButton.Location = new System.Drawing.Point(423, 259);
            this.SetIncomesOutlaysButton.Name = "SetIncomesOutlaysButton";
            this.SetIncomesOutlaysButton.Size = new System.Drawing.Size(121, 56);
            this.SetIncomesOutlaysButton.TabIndex = 8;
            this.SetIncomesOutlaysButton.Text = "Set new Outlays or Incomes";
            this.SetIncomesOutlaysButton.UseVisualStyleBackColor = false;
            // 
            // DataGridViewPlan
            // 
            this.DataGridViewPlan.BackgroundColor = System.Drawing.Color.Aqua;
            this.DataGridViewPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPlan.Location = new System.Drawing.Point(330, 45);
            this.DataGridViewPlan.Name = "DataGridViewPlan";
            this.DataGridViewPlan.RowHeadersWidth = 51;
            this.DataGridViewPlan.RowTemplate.Height = 24;
            this.DataGridViewPlan.Size = new System.Drawing.Size(341, 208);
            this.DataGridViewPlan.TabIndex = 9;
            // 
            // CashLabel
            // 
            this.CashLabel.AutoSize = true;
            this.CashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CashLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.CashLabel.Location = new System.Drawing.Point(134, 45);
            this.CashLabel.Name = "CashLabel";
            this.CashLabel.Size = new System.Drawing.Size(23, 25);
            this.CashLabel.TabIndex = 10;
            this.CashLabel.Text = "0";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(687, 329);
            this.Controls.Add(this.CashLabel);
            this.Controls.Add(this.DataGridViewPlan);
            this.Controls.Add(this.SetIncomesOutlaysButton);
            this.Controls.Add(this.EditPlanButton);
            this.Controls.Add(this.OutlayButton);
            this.Controls.Add(this.IncomeButton);
            this.Controls.Add(this.LastOtlayLabel);
            this.Controls.Add(this.LastIncomeLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.MainMenuLabel);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainMenuLabel;
        private System.Windows.Forms.Label LastIncomeLabel;
        private System.Windows.Forms.Label LastOtlayLabel;
        private System.Windows.Forms.Button IncomeButton;
        private System.Windows.Forms.Button OutlayButton;
        private System.Windows.Forms.Button EditPlanButton;
        private System.Windows.Forms.Button SetIncomesOutlaysButton;
        public System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.DataGridView DataGridViewPlan;
        private System.Windows.Forms.Label CashLabel;
    }
}