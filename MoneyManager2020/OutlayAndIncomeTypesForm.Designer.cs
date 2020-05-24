namespace MoneyManager2020
{
    partial class OutlayAndIncomeTypesForm
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
            this.IncomeTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.incomeTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseUML = new MoneyManager2020.DataBaseUML();
            this.income_TypesTableAdapter = new MoneyManager2020.DataBaseUMLTableAdapters.Income_TypesTableAdapter();
            this.OutlayTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.outlayTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outlay_TypesTableAdapter = new MoneyManager2020.DataBaseUMLTableAdapters.Outlay_TypesTableAdapter();
            this.IncomeIdLabel = new System.Windows.Forms.Label();
            this.IncomeIdTextBox = new System.Windows.Forms.TextBox();
            this.IncomeDescriptionLabel = new System.Windows.Forms.Label();
            this.IncomeDescription = new System.Windows.Forms.TextBox();
            this.OutlayDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutlayIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddIncomeButton = new System.Windows.Forms.Button();
            this.AddOutlayButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeTypesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseUML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutlayTypesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outlayTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // IncomeTypesDataGridView
            // 
            this.IncomeTypesDataGridView.BackgroundColor = System.Drawing.Color.Aqua;
            this.IncomeTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncomeTypesDataGridView.Location = new System.Drawing.Point(168, 43);
            this.IncomeTypesDataGridView.Name = "IncomeTypesDataGridView";
            this.IncomeTypesDataGridView.RowHeadersWidth = 25;
            this.IncomeTypesDataGridView.RowTemplate.Height = 24;
            this.IncomeTypesDataGridView.Size = new System.Drawing.Size(220, 150);
            this.IncomeTypesDataGridView.TabIndex = 0;
            // 
            // incomeTypesBindingSource
            // 
            this.incomeTypesBindingSource.DataMember = "Income_Types";
            this.incomeTypesBindingSource.DataSource = this.dataBaseUML;
            // 
            // dataBaseUML
            // 
            this.dataBaseUML.DataSetName = "DataBaseUML";
            this.dataBaseUML.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // income_TypesTableAdapter
            // 
            this.income_TypesTableAdapter.ClearBeforeFill = true;
            // 
            // OutlayTypesDataGridView
            // 
            this.OutlayTypesDataGridView.BackgroundColor = System.Drawing.Color.Aqua;
            this.OutlayTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutlayTypesDataGridView.Location = new System.Drawing.Point(394, 43);
            this.OutlayTypesDataGridView.Name = "OutlayTypesDataGridView";
            this.OutlayTypesDataGridView.RowHeadersWidth = 25;
            this.OutlayTypesDataGridView.RowTemplate.Height = 24;
            this.OutlayTypesDataGridView.Size = new System.Drawing.Size(220, 150);
            this.OutlayTypesDataGridView.TabIndex = 1;
            // 
            // outlayTypesBindingSource
            // 
            this.outlayTypesBindingSource.DataMember = "Outlay_Types";
            this.outlayTypesBindingSource.DataSource = this.dataBaseUML;
            // 
            // outlay_TypesTableAdapter
            // 
            this.outlay_TypesTableAdapter.ClearBeforeFill = true;
            // 
            // IncomeIdLabel
            // 
            this.IncomeIdLabel.AutoSize = true;
            this.IncomeIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncomeIdLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.IncomeIdLabel.Location = new System.Drawing.Point(1, 43);
            this.IncomeIdLabel.Name = "IncomeIdLabel";
            this.IncomeIdLabel.Size = new System.Drawing.Size(31, 25);
            this.IncomeIdLabel.TabIndex = 2;
            this.IncomeIdLabel.Text = "ID";
            // 
            // IncomeIdTextBox
            // 
            this.IncomeIdTextBox.Location = new System.Drawing.Point(6, 72);
            this.IncomeIdTextBox.Name = "IncomeIdTextBox";
            this.IncomeIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.IncomeIdTextBox.TabIndex = 3;
            // 
            // IncomeDescriptionLabel
            // 
            this.IncomeDescriptionLabel.AutoSize = true;
            this.IncomeDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncomeDescriptionLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.IncomeDescriptionLabel.Location = new System.Drawing.Point(1, 120);
            this.IncomeDescriptionLabel.Name = "IncomeDescriptionLabel";
            this.IncomeDescriptionLabel.Size = new System.Drawing.Size(114, 25);
            this.IncomeDescriptionLabel.TabIndex = 4;
            this.IncomeDescriptionLabel.Text = "Description ";
            // 
            // IncomeDescription
            // 
            this.IncomeDescription.Location = new System.Drawing.Point(6, 158);
            this.IncomeDescription.Name = "IncomeDescription";
            this.IncomeDescription.Size = new System.Drawing.Size(100, 22);
            this.IncomeDescription.TabIndex = 5;
            // 
            // OutlayDescriptionTextBox
            // 
            this.OutlayDescriptionTextBox.Location = new System.Drawing.Point(682, 158);
            this.OutlayDescriptionTextBox.Name = "OutlayDescriptionTextBox";
            this.OutlayDescriptionTextBox.Size = new System.Drawing.Size(100, 22);
            this.OutlayDescriptionTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(677, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Description ";
            // 
            // OutlayIdTextBox
            // 
            this.OutlayIdTextBox.Location = new System.Drawing.Point(682, 72);
            this.OutlayIdTextBox.Name = "OutlayIdTextBox";
            this.OutlayIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.OutlayIdTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(677, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // AddIncomeButton
            // 
            this.AddIncomeButton.BackColor = System.Drawing.Color.DarkCyan;
            this.AddIncomeButton.Location = new System.Drawing.Point(168, 199);
            this.AddIncomeButton.Name = "AddIncomeButton";
            this.AddIncomeButton.Size = new System.Drawing.Size(75, 45);
            this.AddIncomeButton.TabIndex = 10;
            this.AddIncomeButton.Text = "Add income";
            this.AddIncomeButton.UseVisualStyleBackColor = false;
            this.AddIncomeButton.Click += new System.EventHandler(this.AddIncomeButton_Click);
            // 
            // AddOutlayButton
            // 
            this.AddOutlayButton.BackColor = System.Drawing.Color.DarkCyan;
            this.AddOutlayButton.Location = new System.Drawing.Point(539, 199);
            this.AddOutlayButton.Name = "AddOutlayButton";
            this.AddOutlayButton.Size = new System.Drawing.Size(75, 45);
            this.AddOutlayButton.TabIndex = 12;
            this.AddOutlayButton.Text = "Add outlay";
            this.AddOutlayButton.UseVisualStyleBackColor = false;
            this.AddOutlayButton.Click += new System.EventHandler(this.AddOutlayButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(172, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Income types";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(389, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Outlay types";
            // 
            // OutlayAndIncomeTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 277);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddOutlayButton);
            this.Controls.Add(this.AddIncomeButton);
            this.Controls.Add(this.OutlayDescriptionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutlayIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IncomeDescription);
            this.Controls.Add(this.IncomeDescriptionLabel);
            this.Controls.Add(this.IncomeIdTextBox);
            this.Controls.Add(this.IncomeIdLabel);
            this.Controls.Add(this.OutlayTypesDataGridView);
            this.Controls.Add(this.IncomeTypesDataGridView);
            this.Name = "OutlayAndIncomeTypesForm";
            this.Text = "OutlayAndIncomeTypesForm";
            this.Load += new System.EventHandler(this.OutlayAndIncomeTypesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IncomeTypesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseUML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutlayTypesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outlayTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataBaseUML dataBaseUML;
        private System.Windows.Forms.BindingSource incomeTypesBindingSource;
        private DataBaseUMLTableAdapters.Income_TypesTableAdapter income_TypesTableAdapter;
        private System.Windows.Forms.BindingSource outlayTypesBindingSource;
        private DataBaseUMLTableAdapters.Outlay_TypesTableAdapter outlay_TypesTableAdapter;
        private System.Windows.Forms.Label IncomeIdLabel;
        private System.Windows.Forms.Label IncomeDescriptionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddIncomeButton;
        private System.Windows.Forms.Button AddOutlayButton;
        public System.Windows.Forms.DataGridView IncomeTypesDataGridView;
        public System.Windows.Forms.DataGridView OutlayTypesDataGridView;
        public System.Windows.Forms.TextBox IncomeIdTextBox;
        public System.Windows.Forms.TextBox IncomeDescription;
        public System.Windows.Forms.TextBox OutlayIdTextBox;
        public System.Windows.Forms.TextBox OutlayDescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}