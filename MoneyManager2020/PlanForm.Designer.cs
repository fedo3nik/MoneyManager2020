namespace MoneyManager2020
{
    partial class PlanForm
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
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.CashLabel = new System.Windows.Forms.Label();
            this.CashTextBox = new System.Windows.Forms.TextBox();
            this.OutlayTypeID = new System.Windows.Forms.Label();
            this.OutlayTypeIDTextBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(13, 42);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 17);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(16, 63);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.IDTextBox.TabIndex = 1;
            // 
            // CashLabel
            // 
            this.CashLabel.AutoSize = true;
            this.CashLabel.Location = new System.Drawing.Point(16, 92);
            this.CashLabel.Name = "CashLabel";
            this.CashLabel.Size = new System.Drawing.Size(40, 17);
            this.CashLabel.TabIndex = 2;
            this.CashLabel.Text = "Cash";
            // 
            // CashTextBox
            // 
            this.CashTextBox.Location = new System.Drawing.Point(16, 113);
            this.CashTextBox.Name = "CashTextBox";
            this.CashTextBox.Size = new System.Drawing.Size(100, 22);
            this.CashTextBox.TabIndex = 3;
            // 
            // OutlayTypeID
            // 
            this.OutlayTypeID.AutoSize = true;
            this.OutlayTypeID.Location = new System.Drawing.Point(16, 142);
            this.OutlayTypeID.Name = "OutlayTypeID";
            this.OutlayTypeID.Size = new System.Drawing.Size(97, 17);
            this.OutlayTypeID.TabIndex = 4;
            this.OutlayTypeID.Text = "Outlay type ID";
            // 
            // OutlayTypeIDTextBox
            // 
            this.OutlayTypeIDTextBox.Location = new System.Drawing.Point(16, 163);
            this.OutlayTypeIDTextBox.Name = "OutlayTypeIDTextBox";
            this.OutlayTypeIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.OutlayTypeIDTextBox.TabIndex = 5;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(16, 192);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(38, 17);
            this.DateLabel.TabIndex = 6;
            this.DateLabel.Text = "Date";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(16, 213);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(100, 22);
            this.DateTextBox.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(344, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 242);
            this.dataGridView1.TabIndex = 8;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.DarkCyan;
            this.AddButton.Location = new System.Drawing.Point(16, 262);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 44);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Insert outlay";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.DarkCyan;
            this.DeleteButton.Location = new System.Drawing.Point(108, 262);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 44);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete outlay";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.DarkCyan;
            this.UpdateButton.Location = new System.Drawing.Point(200, 262);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 43);
            this.UpdateButton.TabIndex = 11;
            this.UpdateButton.Text = "Update outlay";
            this.UpdateButton.UseVisualStyleBackColor = false;
            // 
            // PlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(621, 341);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.OutlayTypeIDTextBox);
            this.Controls.Add(this.OutlayTypeID);
            this.Controls.Add(this.CashTextBox);
            this.Controls.Add(this.CashLabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.IDLabel);
            this.Name = "PlanForm";
            this.Text = "PlanForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label CashLabel;
        private System.Windows.Forms.TextBox CashTextBox;
        private System.Windows.Forms.Label OutlayTypeID;
        private System.Windows.Forms.TextBox OutlayTypeIDTextBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
    }
}