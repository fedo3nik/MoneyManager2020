namespace MoneyManager2020
{
    partial class AdminMenuForm
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
            this.MenuLabel = new System.Windows.Forms.Label();
            this.UsersListLabel = new System.Windows.Forms.Label();
            this.UsersListDataGridView = new System.Windows.Forms.DataGridView();
            this.IncomeDataGridView = new System.Windows.Forms.DataGridView();
            this.OutlayDataGridView = new System.Windows.Forms.DataGridView();
            this.IncomeLabel = new System.Windows.Forms.Label();
            this.OutlayLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.DiscriptionLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.DescriptTextBox = new System.Windows.Forms.TextBox();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.AddIncomeButton = new System.Windows.Forms.Button();
            this.AddOutlayButton = new System.Windows.Forms.Button();
            this.DeleteOutlayButton = new System.Windows.Forms.Button();
            this.DeleteIncomeButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutlayDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuLabel.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuLabel.ForeColor = System.Drawing.Color.Coral;
            this.MenuLabel.Location = new System.Drawing.Point(12, 9);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(405, 32);
            this.MenuLabel.TabIndex = 2;
            this.MenuLabel.Text = "MoneyManger2020 admin mode";
            // 
            // UsersListLabel
            // 
            this.UsersListLabel.AutoSize = true;
            this.UsersListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersListLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.UsersListLabel.Location = new System.Drawing.Point(434, 66);
            this.UsersListLabel.Name = "UsersListLabel";
            this.UsersListLabel.Size = new System.Drawing.Size(91, 25);
            this.UsersListLabel.TabIndex = 19;
            this.UsersListLabel.Text = "Users list";
            // 
            // UsersListDataGridView
            // 
            this.UsersListDataGridView.BackgroundColor = System.Drawing.Color.Aqua;
            this.UsersListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersListDataGridView.Location = new System.Drawing.Point(439, 94);
            this.UsersListDataGridView.Name = "UsersListDataGridView";
            this.UsersListDataGridView.RowHeadersWidth = 51;
            this.UsersListDataGridView.RowTemplate.Height = 24;
            this.UsersListDataGridView.Size = new System.Drawing.Size(349, 215);
            this.UsersListDataGridView.TabIndex = 20;
            // 
            // IncomeDataGridView
            // 
            this.IncomeDataGridView.BackgroundColor = System.Drawing.Color.Aqua;
            this.IncomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncomeDataGridView.Location = new System.Drawing.Point(12, 94);
            this.IncomeDataGridView.Name = "IncomeDataGridView";
            this.IncomeDataGridView.RowHeadersWidth = 51;
            this.IncomeDataGridView.RowTemplate.Height = 24;
            this.IncomeDataGridView.Size = new System.Drawing.Size(182, 215);
            this.IncomeDataGridView.TabIndex = 21;
            // 
            // OutlayDataGridView
            // 
            this.OutlayDataGridView.BackgroundColor = System.Drawing.Color.Aqua;
            this.OutlayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutlayDataGridView.Location = new System.Drawing.Point(200, 94);
            this.OutlayDataGridView.Name = "OutlayDataGridView";
            this.OutlayDataGridView.RowHeadersWidth = 51;
            this.OutlayDataGridView.RowTemplate.Height = 24;
            this.OutlayDataGridView.Size = new System.Drawing.Size(182, 215);
            this.OutlayDataGridView.TabIndex = 22;
            // 
            // IncomeLabel
            // 
            this.IncomeLabel.AutoSize = true;
            this.IncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncomeLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.IncomeLabel.Location = new System.Drawing.Point(12, 66);
            this.IncomeLabel.Name = "IncomeLabel";
            this.IncomeLabel.Size = new System.Drawing.Size(128, 25);
            this.IncomeLabel.TabIndex = 23;
            this.IncomeLabel.Text = "Income types";
            // 
            // OutlayLabel
            // 
            this.OutlayLabel.AutoSize = true;
            this.OutlayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutlayLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.OutlayLabel.Location = new System.Drawing.Point(195, 66);
            this.OutlayLabel.Name = "OutlayLabel";
            this.OutlayLabel.Size = new System.Drawing.Size(121, 25);
            this.OutlayLabel.TabIndex = 24;
            this.OutlayLabel.Text = "Outlay types";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.IdLabel.Location = new System.Drawing.Point(12, 330);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(31, 25);
            this.IdLabel.TabIndex = 25;
            this.IdLabel.Text = "ID";
            // 
            // DiscriptionLabel
            // 
            this.DiscriptionLabel.AutoSize = true;
            this.DiscriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscriptionLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.DiscriptionLabel.Location = new System.Drawing.Point(12, 382);
            this.DiscriptionLabel.Name = "DiscriptionLabel";
            this.DiscriptionLabel.Size = new System.Drawing.Size(102, 25);
            this.DiscriptionLabel.TabIndex = 26;
            this.DiscriptionLabel.Text = "Discription";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(17, 359);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 22);
            this.IdTextBox.TabIndex = 27;
            // 
            // DescriptTextBox
            // 
            this.DescriptTextBox.Location = new System.Drawing.Point(17, 411);
            this.DescriptTextBox.Name = "DescriptTextBox";
            this.DescriptTextBox.Size = new System.Drawing.Size(100, 22);
            this.DescriptTextBox.TabIndex = 28;
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(439, 359);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.UserIdTextBox.TabIndex = 30;
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserIdLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.UserIdLabel.Location = new System.Drawing.Point(434, 330);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(77, 25);
            this.UserIdLabel.TabIndex = 29;
            this.UserIdLabel.Text = "User ID";
            // 
            // AddIncomeButton
            // 
            this.AddIncomeButton.BackColor = System.Drawing.Color.DarkCyan;
            this.AddIncomeButton.Location = new System.Drawing.Point(200, 330);
            this.AddIncomeButton.Name = "AddIncomeButton";
            this.AddIncomeButton.Size = new System.Drawing.Size(75, 42);
            this.AddIncomeButton.TabIndex = 31;
            this.AddIncomeButton.Text = "Add income";
            this.AddIncomeButton.UseVisualStyleBackColor = false;
            this.AddIncomeButton.Click += new System.EventHandler(this.AddIncomeButton_Click);
            // 
            // AddOutlayButton
            // 
            this.AddOutlayButton.BackColor = System.Drawing.Color.DarkCyan;
            this.AddOutlayButton.Location = new System.Drawing.Point(281, 330);
            this.AddOutlayButton.Name = "AddOutlayButton";
            this.AddOutlayButton.Size = new System.Drawing.Size(75, 42);
            this.AddOutlayButton.TabIndex = 32;
            this.AddOutlayButton.Text = "Add outlay";
            this.AddOutlayButton.UseVisualStyleBackColor = false;
            this.AddOutlayButton.Click += new System.EventHandler(this.AddOutlayButton_Click);
            // 
            // DeleteOutlayButton
            // 
            this.DeleteOutlayButton.BackColor = System.Drawing.Color.DarkCyan;
            this.DeleteOutlayButton.Location = new System.Drawing.Point(281, 378);
            this.DeleteOutlayButton.Name = "DeleteOutlayButton";
            this.DeleteOutlayButton.Size = new System.Drawing.Size(75, 42);
            this.DeleteOutlayButton.TabIndex = 33;
            this.DeleteOutlayButton.Text = "Delete outlay";
            this.DeleteOutlayButton.UseVisualStyleBackColor = false;
            this.DeleteOutlayButton.Click += new System.EventHandler(this.DeleteOutlayButton_Click);
            // 
            // DeleteIncomeButton
            // 
            this.DeleteIncomeButton.BackColor = System.Drawing.Color.DarkCyan;
            this.DeleteIncomeButton.Location = new System.Drawing.Point(200, 378);
            this.DeleteIncomeButton.Name = "DeleteIncomeButton";
            this.DeleteIncomeButton.Size = new System.Drawing.Size(75, 42);
            this.DeleteIncomeButton.TabIndex = 34;
            this.DeleteIncomeButton.Text = "Delete income";
            this.DeleteIncomeButton.UseVisualStyleBackColor = false;
            this.DeleteIncomeButton.Click += new System.EventHandler(this.DeleteIncomeButton_Click);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.BackColor = System.Drawing.Color.DarkCyan;
            this.DeleteUserButton.Location = new System.Drawing.Point(565, 330);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(150, 51);
            this.DeleteUserButton.TabIndex = 35;
            this.DeleteUserButton.Text = "Delete user";
            this.DeleteUserButton.UseVisualStyleBackColor = false;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.DeleteIncomeButton);
            this.Controls.Add(this.DeleteOutlayButton);
            this.Controls.Add(this.AddOutlayButton);
            this.Controls.Add(this.AddIncomeButton);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.UserIdLabel);
            this.Controls.Add(this.DescriptTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.DiscriptionLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.OutlayLabel);
            this.Controls.Add(this.IncomeLabel);
            this.Controls.Add(this.OutlayDataGridView);
            this.Controls.Add(this.IncomeDataGridView);
            this.Controls.Add(this.UsersListDataGridView);
            this.Controls.Add(this.UsersListLabel);
            this.Controls.Add(this.MenuLabel);
            this.Name = "AdminMenuForm";
            this.Text = "AdminMenuForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMenuForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutlayDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MenuLabel;
        public System.Windows.Forms.Label UsersListLabel;
        public System.Windows.Forms.Label IncomeLabel;
        public System.Windows.Forms.Label OutlayLabel;
        public System.Windows.Forms.Label IdLabel;
        public System.Windows.Forms.Label DiscriptionLabel;
        public System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.Button AddIncomeButton;
        private System.Windows.Forms.Button AddOutlayButton;
        private System.Windows.Forms.Button DeleteOutlayButton;
        private System.Windows.Forms.Button DeleteIncomeButton;
        private System.Windows.Forms.Button DeleteUserButton;
        public System.Windows.Forms.DataGridView UsersListDataGridView;
        public System.Windows.Forms.DataGridView IncomeDataGridView;
        public System.Windows.Forms.DataGridView OutlayDataGridView;
        public System.Windows.Forms.TextBox IdTextBox;
        public System.Windows.Forms.TextBox DescriptTextBox;
        public System.Windows.Forms.TextBox UserIdTextBox;
    }
}