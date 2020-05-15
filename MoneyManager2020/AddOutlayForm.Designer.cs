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
            this.IncomeTypeIDTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.CashTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.DataGridViewOutlayTypes = new System.Windows.Forms.DataGridView();
            this.AddOutlayButton = new System.Windows.Forms.Button();
            this.OutlayTypeID = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.CashLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOutlayTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // IncomeTypeIDTextBox
            // 
            this.IncomeTypeIDTextBox.Location = new System.Drawing.Point(14, 193);
            this.IncomeTypeIDTextBox.Name = "IncomeTypeIDTextBox";
            this.IncomeTypeIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.IncomeTypeIDTextBox.TabIndex = 19;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(14, 147);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(100, 22);
            this.DateTextBox.TabIndex = 18;
            // 
            // CashTextBox
            // 
            this.CashTextBox.Location = new System.Drawing.Point(12, 89);
            this.CashTextBox.Name = "CashTextBox";
            this.CashTextBox.Size = new System.Drawing.Size(102, 22);
            this.CashTextBox.TabIndex = 17;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(14, 43);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.IDTextBox.TabIndex = 16;
            // 
            // DataGridViewOutlayTypes
            // 
            this.DataGridViewOutlayTypes.BackgroundColor = System.Drawing.Color.Aqua;
            this.DataGridViewOutlayTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewOutlayTypes.Location = new System.Drawing.Point(193, 43);
            this.DataGridViewOutlayTypes.Name = "DataGridViewOutlayTypes";
            this.DataGridViewOutlayTypes.RowHeadersWidth = 51;
            this.DataGridViewOutlayTypes.RowTemplate.Height = 24;
            this.DataGridViewOutlayTypes.Size = new System.Drawing.Size(272, 213);
            this.DataGridViewOutlayTypes.TabIndex = 15;
            // 
            // AddOutlayButton
            // 
            this.AddOutlayButton.Location = new System.Drawing.Point(14, 221);
            this.AddOutlayButton.Name = "AddOutlayButton";
            this.AddOutlayButton.Size = new System.Drawing.Size(75, 44);
            this.AddOutlayButton.TabIndex = 14;
            this.AddOutlayButton.Text = "Add outlay";
            this.AddOutlayButton.UseVisualStyleBackColor = true;
            // 
            // OutlayTypeID
            // 
            this.OutlayTypeID.AutoSize = true;
            this.OutlayTypeID.Location = new System.Drawing.Point(9, 172);
            this.OutlayTypeID.Name = "OutlayTypeID";
            this.OutlayTypeID.Size = new System.Drawing.Size(98, 17);
            this.OutlayTypeID.TabIndex = 13;
            this.OutlayTypeID.Text = "IncomeTypeID";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(9, 124);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(38, 17);
            this.DateLabel.TabIndex = 12;
            this.DateLabel.Text = "Date";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(11, 23);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 17);
            this.IDLabel.TabIndex = 11;
            this.IDLabel.Text = "ID";
            // 
            // CashLabel
            // 
            this.CashLabel.AutoSize = true;
            this.CashLabel.Location = new System.Drawing.Point(9, 68);
            this.CashLabel.Name = "CashLabel";
            this.CashLabel.Size = new System.Drawing.Size(40, 17);
            this.CashLabel.TabIndex = 10;
            this.CashLabel.Text = "Cash";
            // 
            // AddOutlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(485, 272);
            this.Controls.Add(this.IncomeTypeIDTextBox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.CashTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.DataGridViewOutlayTypes);
            this.Controls.Add(this.AddOutlayButton);
            this.Controls.Add(this.OutlayTypeID);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.CashLabel);
            this.Name = "AddOutlayForm";
            this.Text = "AddOutlayForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOutlayTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IncomeTypeIDTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox CashTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.DataGridView DataGridViewOutlayTypes;
        private System.Windows.Forms.Button AddOutlayButton;
        private System.Windows.Forms.Label OutlayTypeID;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label CashLabel;
    }
}