namespace CountryInfoApp
{
    partial class CountryInfoAppForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountryInfoAppForm));
			this.countryNameEnterButton = new System.Windows.Forms.Button();
			this.countryInfoOutputButton = new System.Windows.Forms.Button();
			this.countryNameTextBox = new System.Windows.Forms.TextBox();
			this.countryInfoDataGridView = new System.Windows.Forms.DataGridView();
			this.CountryNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CountryCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CapitalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CountrySquareColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PopulationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RegionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countryNameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.countryInfoDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// countryNameEnterButton
			// 
			resources.ApplyResources(this.countryNameEnterButton, "countryNameEnterButton");
			this.countryNameEnterButton.Name = "countryNameEnterButton";
			this.countryNameEnterButton.UseVisualStyleBackColor = true;
			this.countryNameEnterButton.Click += new System.EventHandler(this.countryNameEnterButton_Click);
			// 
			// countryInfoOutputButton
			// 
			resources.ApplyResources(this.countryInfoOutputButton, "countryInfoOutputButton");
			this.countryInfoOutputButton.Name = "countryInfoOutputButton";
			this.countryInfoOutputButton.UseVisualStyleBackColor = true;
			this.countryInfoOutputButton.Click += new System.EventHandler(this.countryInfoOutputButton_Click);
			// 
			// countryNameTextBox
			// 
			resources.ApplyResources(this.countryNameTextBox, "countryNameTextBox");
			this.countryNameTextBox.Name = "countryNameTextBox";
			// 
			// countryInfoDataGridView
			// 
			this.countryInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.countryInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CountryNameColumn,
            this.CountryCodeColumn,
            this.CapitalColumn,
            this.CountrySquareColumn,
            this.PopulationColumn,
            this.RegionColumn});
			resources.ApplyResources(this.countryInfoDataGridView, "countryInfoDataGridView");
			this.countryInfoDataGridView.Name = "countryInfoDataGridView";
			this.countryInfoDataGridView.ReadOnly = true;
			// 
			// CountryNameColumn
			// 
			resources.ApplyResources(this.CountryNameColumn, "CountryNameColumn");
			this.CountryNameColumn.Name = "CountryNameColumn";
			this.CountryNameColumn.ReadOnly = true;
			// 
			// CountryCodeColumn
			// 
			resources.ApplyResources(this.CountryCodeColumn, "CountryCodeColumn");
			this.CountryCodeColumn.Name = "CountryCodeColumn";
			this.CountryCodeColumn.ReadOnly = true;
			// 
			// CapitalColumn
			// 
			resources.ApplyResources(this.CapitalColumn, "CapitalColumn");
			this.CapitalColumn.Name = "CapitalColumn";
			this.CapitalColumn.ReadOnly = true;
			// 
			// CountrySquareColumn
			// 
			resources.ApplyResources(this.CountrySquareColumn, "CountrySquareColumn");
			this.CountrySquareColumn.Name = "CountrySquareColumn";
			this.CountrySquareColumn.ReadOnly = true;
			// 
			// PopulationColumn
			// 
			resources.ApplyResources(this.PopulationColumn, "PopulationColumn");
			this.PopulationColumn.Name = "PopulationColumn";
			this.PopulationColumn.ReadOnly = true;
			// 
			// RegionColumn
			// 
			resources.ApplyResources(this.RegionColumn, "RegionColumn");
			this.RegionColumn.Name = "RegionColumn";
			this.RegionColumn.ReadOnly = true;
			// 
			// countryNameLabel
			// 
			resources.ApplyResources(this.countryNameLabel, "countryNameLabel");
			this.countryNameLabel.Name = "countryNameLabel";
			// 
			// CountryInfoAppForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.countryNameLabel);
			this.Controls.Add(this.countryInfoDataGridView);
			this.Controls.Add(this.countryNameTextBox);
			this.Controls.Add(this.countryInfoOutputButton);
			this.Controls.Add(this.countryNameEnterButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "CountryInfoAppForm";
			((System.ComponentModel.ISupportInitialize)(this.countryInfoDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button countryNameEnterButton;
        private System.Windows.Forms.Button countryInfoOutputButton;
        private System.Windows.Forms.TextBox countryNameTextBox;
        private System.Windows.Forms.DataGridView countryInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapitalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountrySquareColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PopulationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegionColumn;
        private System.Windows.Forms.Label countryNameLabel;
    }
}

