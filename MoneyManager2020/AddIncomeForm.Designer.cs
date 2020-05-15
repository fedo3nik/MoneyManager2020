namespace MoneyManager2020
{
    partial class AddIncomeForm
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
            this.CashLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.IncomeTypeID = new System.Windows.Forms.Label();
            this.AddIncomeButton = new System.Windows.Forms.Button();
            this.DataGridViewIncomeTypes = new System.Windows.Forms.DataGridView();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.CashTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.IncomeTypeIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewIncomeTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // CashLabel
            // 
            this.CashLabel.AutoSize = true;
            this.CashLabel.Location = new System.Drawing.Point(1, 69);
            this.CashLabel.Name = "CashLabel";
            this.CashLabel.Size = new System.Drawing.Size(40, 17);
            this.CashLabel.TabIndex = 0;
            this.CashLabel.Text = "Cash";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(3, 24);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 17);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "ID";
            this.IDLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(1, 125);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(38, 17);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Date";
            // 
            // IncomeTypeID
            // 
            this.IncomeTypeID.AutoSize = true;
            this.IncomeTypeID.Location = new System.Drawing.Point(1, 173);
            this.IncomeTypeID.Name = "IncomeTypeID";
            this.IncomeTypeID.Size = new System.Drawing.Size(98, 17);
            this.IncomeTypeID.TabIndex = 3;
            this.IncomeTypeID.Text = "IncomeTypeID";
            // 
            // AddIncomeButton
            // 
            this.AddIncomeButton.Location = new System.Drawing.Point(6, 222);
            this.AddIncomeButton.Name = "AddIncomeButton";
            this.AddIncomeButton.Size = new System.Drawing.Size(75, 44);
            this.AddIncomeButton.TabIndex = 4;
            this.AddIncomeButton.Text = "Add income";
            this.AddIncomeButton.UseVisualStyleBackColor = true;
            // 
            // DataGridViewIncomeTypes
            // 
            this.DataGridViewIncomeTypes.BackgroundColor = System.Drawing.Color.Aqua;
            this.DataGridViewIncomeTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewIncomeTypes.Location = new System.Drawing.Point(194, 44);
            this.DataGridViewIncomeTypes.Name = "DataGridViewIncomeTypes";
            this.DataGridViewIncomeTypes.RowHeadersWidth = 51;
            this.DataGridViewIncomeTypes.RowTemplate.Height = 24;
            this.DataGridViewIncomeTypes.Size = new System.Drawing.Size(272, 213);
            this.DataGridViewIncomeTypes.TabIndex = 5;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(6, 44);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.IDTextBox.TabIndex = 6;
            // 
            // CashTextBox
            // 
            this.CashTextBox.Location = new System.Drawing.Point(4, 90);
            this.CashTextBox.Name = "CashTextBox";
            this.CashTextBox.Size = new System.Drawing.Size(102, 22);
            this.CashTextBox.TabIndex = 7;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(6, 148);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(100, 22);
            this.DateTextBox.TabIndex = 8;
            // 
            // IncomeTypeIDTextBox
            // 
            this.IncomeTypeIDTextBox.Location = new System.Drawing.Point(6, 194);
            this.IncomeTypeIDTextBox.Name = "IncomeTypeIDTextBox";
            this.IncomeTypeIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.IncomeTypeIDTextBox.TabIndex = 9;
            // 
            // AddIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(478, 285);
            this.Controls.Add(this.IncomeTypeIDTextBox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.CashTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.DataGridViewIncomeTypes);
            this.Controls.Add(this.AddIncomeButton);
            this.Controls.Add(this.IncomeTypeID);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.CashLabel);
            this.Name = "AddIncomeForm";
            this.Text = "AddIncomeForm";
            this.Load += new System.EventHandler(this.AddIncomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewIncomeTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CashLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label IncomeTypeID;
        private System.Windows.Forms.Button AddIncomeButton;
        private System.Windows.Forms.DataGridView DataGridViewIncomeTypes;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox CashTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox IncomeTypeIDTextBox;
    }
}