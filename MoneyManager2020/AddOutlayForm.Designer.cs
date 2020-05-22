namespace MoneyManager2020
{
    partial class AddOutlayForm
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
            this.OutlayTypesLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.OutlayTypeIdLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.CashLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IncomeTypeIDTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.CashTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.DataGridViewOutlayTypes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOutlayTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // OutlayTypesLabel
            // 
            this.OutlayTypesLabel.AutoSize = true;
            this.OutlayTypesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutlayTypesLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.OutlayTypesLabel.Location = new System.Drawing.Point(198, 9);
            this.OutlayTypesLabel.Name = "OutlayTypesLabel";
            this.OutlayTypesLabel.Size = new System.Drawing.Size(121, 25);
            this.OutlayTypesLabel.TabIndex = 26;
            this.OutlayTypesLabel.Text = "Outlay types";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.DarkCyan;
            this.AddButton.Location = new System.Drawing.Point(2, 222);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 56);
            this.AddButton.TabIndex = 25;
            this.AddButton.Text = "Add Outlay";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OutlayTypeIdLabel
            // 
            this.OutlayTypeIdLabel.AutoSize = true;
            this.OutlayTypeIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutlayTypeIdLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.OutlayTypeIdLabel.Location = new System.Drawing.Point(-1, 170);
            this.OutlayTypeIdLabel.Name = "OutlayTypeIdLabel";
            this.OutlayTypeIdLabel.Size = new System.Drawing.Size(135, 25);
            this.OutlayTypeIdLabel.TabIndex = 24;
            this.OutlayTypeIdLabel.Text = "Outlay type ID";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.DateLabel.Location = new System.Drawing.Point(-1, 117);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(53, 25);
            this.DateLabel.TabIndex = 23;
            this.DateLabel.Text = "Date";
            // 
            // CashLabel
            // 
            this.CashLabel.AutoSize = true;
            this.CashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CashLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.CashLabel.Location = new System.Drawing.Point(-1, 62);
            this.CashLabel.Name = "CashLabel";
            this.CashLabel.Size = new System.Drawing.Size(59, 25);
            this.CashLabel.TabIndex = 22;
            this.CashLabel.Text = "Cash";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.IDLabel.Location = new System.Drawing.Point(-1, 9);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(31, 25);
            this.IDLabel.TabIndex = 21;
            this.IDLabel.Text = "ID";
            // 
            // IncomeTypeIDTextBox
            // 
            this.IncomeTypeIDTextBox.Location = new System.Drawing.Point(4, 194);
            this.IncomeTypeIDTextBox.Name = "IncomeTypeIDTextBox";
            this.IncomeTypeIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.IncomeTypeIDTextBox.TabIndex = 20;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(2, 145);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(100, 22);
            this.DateTextBox.TabIndex = 19;
            // 
            // CashTextBox
            // 
            this.CashTextBox.Location = new System.Drawing.Point(2, 90);
            this.CashTextBox.Name = "CashTextBox";
            this.CashTextBox.Size = new System.Drawing.Size(102, 22);
            this.CashTextBox.TabIndex = 18;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(2, 37);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.IDTextBox.TabIndex = 17;
            // 
            // DataGridViewOutlayTypes
            // 
            this.DataGridViewOutlayTypes.BackgroundColor = System.Drawing.Color.Aqua;
            this.DataGridViewOutlayTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewOutlayTypes.Location = new System.Drawing.Point(203, 37);
            this.DataGridViewOutlayTypes.Name = "DataGridViewOutlayTypes";
            this.DataGridViewOutlayTypes.RowHeadersWidth = 51;
            this.DataGridViewOutlayTypes.RowTemplate.Height = 24;
            this.DataGridViewOutlayTypes.Size = new System.Drawing.Size(272, 213);
            this.DataGridViewOutlayTypes.TabIndex = 16;
            // 
            // AddOutlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(485, 292);
            this.Controls.Add(this.OutlayTypesLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.OutlayTypeIdLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.CashLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.IncomeTypeIDTextBox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.CashTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.DataGridViewOutlayTypes);
            this.Name = "AddOutlayForm";
            this.Text = "AddOutlayForm";
            this.Load += new System.EventHandler(this.AddOutlayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOutlayTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label OutlayTypesLabel;
        private System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.Label OutlayTypeIdLabel;
        public System.Windows.Forms.Label DateLabel;
        public System.Windows.Forms.Label CashLabel;
        public System.Windows.Forms.Label IDLabel;
        public System.Windows.Forms.TextBox IncomeTypeIDTextBox;
        public System.Windows.Forms.TextBox DateTextBox;
        public System.Windows.Forms.TextBox CashTextBox;
        public System.Windows.Forms.TextBox IDTextBox;
        public System.Windows.Forms.DataGridView DataGridViewOutlayTypes;
    }
}