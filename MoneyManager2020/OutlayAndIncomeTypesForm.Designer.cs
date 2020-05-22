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
            this.DeleteIncomeButton = new System.Windows.Forms.Button();
            this.AddOutlayButton = new System.Windows.Forms.Button();
            this.DeleteOutlayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeTypesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseUML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutlayTypesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outlayTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // IncomeTypesDataGridView
            // 
            this.IncomeTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncomeTypesDataGridView.Location = new System.Drawing.Point(174, 90);
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
            this.OutlayTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutlayTypesDataGridView.Location = new System.Drawing.Point(400, 90);
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
            this.IncomeIdLabel.Location = new System.Drawing.Point(7, 90);
            this.IncomeIdLabel.Name = "IncomeIdLabel";
            this.IncomeIdLabel.Size = new System.Drawing.Size(31, 25);
            this.IncomeIdLabel.TabIndex = 2;
            this.IncomeIdLabel.Text = "ID";
            // 
            // IncomeIdTextBox
            // 
            this.IncomeIdTextBox.Location = new System.Drawing.Point(12, 119);
            this.IncomeIdTextBox.Name = "IncomeIdTextBox";
            this.IncomeIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.IncomeIdTextBox.TabIndex = 3;
            // 
            // IncomeDescriptionLabel
            // 
            this.IncomeDescriptionLabel.AutoSize = true;
            this.IncomeDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncomeDescriptionLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.IncomeDescriptionLabel.Location = new System.Drawing.Point(7, 167);
            this.IncomeDescriptionLabel.Name = "IncomeDescriptionLabel";
            this.IncomeDescriptionLabel.Size = new System.Drawing.Size(114, 25);
            this.IncomeDescriptionLabel.TabIndex = 4;
            this.IncomeDescriptionLabel.Text = "Description ";
            // 
            // IncomeDescription
            // 
            this.IncomeDescription.Location = new System.Drawing.Point(12, 205);
            this.IncomeDescription.Name = "IncomeDescription";
            this.IncomeDescription.Size = new System.Drawing.Size(100, 22);
            this.IncomeDescription.TabIndex = 5;
            // 
            // OutlayDescriptionTextBox
            // 
            this.OutlayDescriptionTextBox.Location = new System.Drawing.Point(688, 205);
            this.OutlayDescriptionTextBox.Name = "OutlayDescriptionTextBox";
            this.OutlayDescriptionTextBox.Size = new System.Drawing.Size(100, 22);
            this.OutlayDescriptionTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(683, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Description ";
            // 
            // OutlayIdTextBox
            // 
            this.OutlayIdTextBox.Location = new System.Drawing.Point(688, 119);
            this.OutlayIdTextBox.Name = "OutlayIdTextBox";
            this.OutlayIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.OutlayIdTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(683, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // AddIncomeButton
            // 
            this.AddIncomeButton.Location = new System.Drawing.Point(174, 246);
            this.AddIncomeButton.Name = "AddIncomeButton";
            this.AddIncomeButton.Size = new System.Drawing.Size(75, 45);
            this.AddIncomeButton.TabIndex = 10;
            this.AddIncomeButton.Text = "Add income";
            this.AddIncomeButton.UseVisualStyleBackColor = true;
            this.AddIncomeButton.Click += new System.EventHandler(this.AddIncomeButton_Click);
            // 
            // DeleteIncomeButton
            // 
            this.DeleteIncomeButton.Location = new System.Drawing.Point(319, 246);
            this.DeleteIncomeButton.Name = "DeleteIncomeButton";
            this.DeleteIncomeButton.Size = new System.Drawing.Size(75, 45);
            this.DeleteIncomeButton.TabIndex = 11;
            this.DeleteIncomeButton.Text = "Delete income";
            this.DeleteIncomeButton.UseVisualStyleBackColor = true;
            this.DeleteIncomeButton.Click += new System.EventHandler(this.DeleteIncomeButton_Click);
            // 
            // AddOutlayButton
            // 
            this.AddOutlayButton.Location = new System.Drawing.Point(400, 246);
            this.AddOutlayButton.Name = "AddOutlayButton";
            this.AddOutlayButton.Size = new System.Drawing.Size(75, 45);
            this.AddOutlayButton.TabIndex = 12;
            this.AddOutlayButton.Text = "Add outlay";
            this.AddOutlayButton.UseVisualStyleBackColor = true;
            this.AddOutlayButton.Click += new System.EventHandler(this.AddOutlayButton_Click);
            // 
            // DeleteOutlayButton
            // 
            this.DeleteOutlayButton.Location = new System.Drawing.Point(545, 246);
            this.DeleteOutlayButton.Name = "DeleteOutlayButton";
            this.DeleteOutlayButton.Size = new System.Drawing.Size(75, 45);
            this.DeleteOutlayButton.TabIndex = 13;
            this.DeleteOutlayButton.Text = "Delete outlay";
            this.DeleteOutlayButton.UseVisualStyleBackColor = true;
            this.DeleteOutlayButton.Click += new System.EventHandler(this.DeleteOutlayButton_Click);
            // 
            // OutlayAndIncomeTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.DeleteOutlayButton);
            this.Controls.Add(this.AddOutlayButton);
            this.Controls.Add(this.DeleteIncomeButton);
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
        private System.Windows.Forms.Button DeleteIncomeButton;
        private System.Windows.Forms.Button AddOutlayButton;
        private System.Windows.Forms.Button DeleteOutlayButton;
        public System.Windows.Forms.DataGridView IncomeTypesDataGridView;
        public System.Windows.Forms.DataGridView OutlayTypesDataGridView;
        public System.Windows.Forms.TextBox IncomeIdTextBox;
        public System.Windows.Forms.TextBox IncomeDescription;
        public System.Windows.Forms.TextBox OutlayIdTextBox;
        public System.Windows.Forms.TextBox OutlayDescriptionTextBox;
    }
}