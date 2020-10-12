namespace CountryInfoApp
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countryInfoDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // countryNameEnterButton
            // 
            this.countryNameEnterButton.Location = new System.Drawing.Point(12, 180);
            this.countryNameEnterButton.Name = "countryNameEnterButton";
            this.countryNameEnterButton.Size = new System.Drawing.Size(123, 37);
            this.countryNameEnterButton.TabIndex = 0;
            this.countryNameEnterButton.Text = "Ввод названия страны";
            this.countryNameEnterButton.UseVisualStyleBackColor = true;
            this.countryNameEnterButton.Click += new System.EventHandler(this.countryNameEnterButton_Click);
            // 
            // countryInfoOutputButton
            // 
            this.countryInfoOutputButton.Location = new System.Drawing.Point(12, 223);
            this.countryInfoOutputButton.Name = "countryInfoOutputButton";
            this.countryInfoOutputButton.Size = new System.Drawing.Size(123, 36);
            this.countryInfoOutputButton.TabIndex = 1;
            this.countryInfoOutputButton.Text = "Вывод всех стран с БД";
            this.countryInfoOutputButton.UseVisualStyleBackColor = true;
            this.countryInfoOutputButton.Click += new System.EventHandler(this.countryInfoOutputButton_Click);
            // 
            // countryNameTextBox
            // 
            this.countryNameTextBox.Location = new System.Drawing.Point(12, 154);
            this.countryNameTextBox.Name = "countryNameTextBox";
            this.countryNameTextBox.Size = new System.Drawing.Size(123, 20);
            this.countryNameTextBox.TabIndex = 2;
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
            this.countryInfoDataGridView.Location = new System.Drawing.Point(141, 38);
            this.countryInfoDataGridView.Name = "countryInfoDataGridView";
            this.countryInfoDataGridView.ReadOnly = true;
            this.countryInfoDataGridView.Size = new System.Drawing.Size(647, 400);
            this.countryInfoDataGridView.TabIndex = 3;
            // 
            // CountryNameColumn
            // 
            this.CountryNameColumn.HeaderText = "Название";
            this.CountryNameColumn.Name = "CountryNameColumn";
            this.CountryNameColumn.ReadOnly = true;
            // 
            // CountryCodeColumn
            // 
            this.CountryCodeColumn.HeaderText = "Код страны";
            this.CountryCodeColumn.Name = "CountryCodeColumn";
            this.CountryCodeColumn.ReadOnly = true;
            // 
            // CapitalColumn
            // 
            this.CapitalColumn.HeaderText = "Столица";
            this.CapitalColumn.Name = "CapitalColumn";
            this.CapitalColumn.ReadOnly = true;
            // 
            // CountrySquareColumn
            // 
            this.CountrySquareColumn.HeaderText = "Площадь";
            this.CountrySquareColumn.Name = "CountrySquareColumn";
            this.CountrySquareColumn.ReadOnly = true;
            // 
            // PopulationColumn
            // 
            this.PopulationColumn.HeaderText = "Население";
            this.PopulationColumn.Name = "PopulationColumn";
            this.PopulationColumn.ReadOnly = true;
            // 
            // RegionColumn
            // 
            this.RegionColumn.HeaderText = "Регион";
            this.RegionColumn.Name = "RegionColumn";
            this.RegionColumn.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базаДанныхToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.базаДанныхToolStripMenuItem.Text = "База данных";
            // 
            // countryNameLabel
            // 
            this.countryNameLabel.AutoSize = true;
            this.countryNameLabel.Location = new System.Drawing.Point(12, 138);
            this.countryNameLabel.Name = "countryNameLabel";
            this.countryNameLabel.Size = new System.Drawing.Size(97, 13);
            this.countryNameLabel.TabIndex = 5;
            this.countryNameLabel.Text = "Название страны";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countryNameLabel);
            this.Controls.Add(this.countryInfoDataGridView);
            this.Controls.Add(this.countryNameTextBox);
            this.Controls.Add(this.countryInfoOutputButton);
            this.Controls.Add(this.countryNameEnterButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.countryInfoDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.Label countryNameLabel;
    }
}

