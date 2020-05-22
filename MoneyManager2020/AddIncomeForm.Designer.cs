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
            this.DataGridViewIncomeTypes = new System.Windows.Forms.DataGridView();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.CashTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.IncomeTypeIDTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.CashLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.IncomeTypesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewIncomeTypes)).BeginInit();
            this.SuspendLayout();
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
            this.IDTextBox.Location = new System.Drawing.Point(4, 37);
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
            this.DateTextBox.Location = new System.Drawing.Point(4, 145);
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
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.IDLabel.Location = new System.Drawing.Point(1, 9);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(31, 25);
            this.IDLabel.TabIndex = 10;
            this.IDLabel.Text = "ID";
            // 
            // CashLabel
            // 
            this.CashLabel.AutoSize = true;
            this.CashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CashLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.CashLabel.Location = new System.Drawing.Point(1, 62);
            this.CashLabel.Name = "CashLabel";
            this.CashLabel.Size = new System.Drawing.Size(59, 25);
            this.CashLabel.TabIndex = 11;
            this.CashLabel.Text = "Cash";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.DateLabel.Location = new System.Drawing.Point(1, 117);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(53, 25);
            this.DateLabel.TabIndex = 12;
            this.DateLabel.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(1, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Income type ID";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.DarkCyan;
            this.AddButton.Location = new System.Drawing.Point(4, 222);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 56);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add Income";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // IncomeTypesLabel
            // 
            this.IncomeTypesLabel.AutoSize = true;
            this.IncomeTypesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncomeTypesLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.IncomeTypesLabel.Location = new System.Drawing.Point(189, 16);
            this.IncomeTypesLabel.Name = "IncomeTypesLabel";
            this.IncomeTypesLabel.Size = new System.Drawing.Size(128, 25);
            this.IncomeTypesLabel.TabIndex = 15;
            this.IncomeTypesLabel.Text = "Income types";
            // 
            // AddIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(478, 285);
            this.Controls.Add(this.IncomeTypesLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.CashLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.IncomeTypeIDTextBox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.CashTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.DataGridViewIncomeTypes);
            this.Name = "AddIncomeForm";
            this.Text = "Add Income";
            this.Load += new System.EventHandler(this.AddIncomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewIncomeTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label IDLabel;
        public System.Windows.Forms.Label CashLabel;
        public System.Windows.Forms.Label DateLabel;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.Label IncomeTypesLabel;
        public System.Windows.Forms.DataGridView DataGridViewIncomeTypes;
        public System.Windows.Forms.TextBox IDTextBox;
        public System.Windows.Forms.TextBox CashTextBox;
        public System.Windows.Forms.TextBox DateTextBox;
        public System.Windows.Forms.TextBox IncomeTypeIDTextBox;
    }
}