namespace DmitrievaKursach
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фааToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.faqMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDataTable = new System.Windows.Forms.DataGridView();
            this.corporateDataTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.corporateUrlAdd = new System.Windows.Forms.Button();
            this.corporateUrlDelete = new System.Windows.Forms.Button();
            this.corporateUrlTextField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corporateDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фааToolStripMenuItem,
            this.analyzeMenuButton,
            this.faqMenuButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1148, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фааToolStripMenuItem
            // 
            this.фааToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importMenuButton});
            this.фааToolStripMenuItem.Name = "фааToolStripMenuItem";
            this.фааToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.фааToolStripMenuItem.Text = "Файл";
            // 
            // importMenuButton
            // 
            this.importMenuButton.Name = "importMenuButton";
            this.importMenuButton.Size = new System.Drawing.Size(118, 22);
            this.importMenuButton.Text = "Импорт";
            this.importMenuButton.Click += new System.EventHandler(this.importMenuButton_Click);
            // 
            // analyzeMenuButton
            // 
            this.analyzeMenuButton.Name = "analyzeMenuButton";
            this.analyzeMenuButton.Size = new System.Drawing.Size(59, 20);
            this.analyzeMenuButton.Text = "Анализ";
            this.analyzeMenuButton.Click += new System.EventHandler(this.analyzeMenuButton_Click);
            // 
            // faqMenuButton
            // 
            this.faqMenuButton.Name = "faqMenuButton";
            this.faqMenuButton.Size = new System.Drawing.Size(65, 20);
            this.faqMenuButton.Text = "Справка";
            this.faqMenuButton.Click += new System.EventHandler(this.faqMenuButton_Click);
            // 
            // inputDataTable
            // 
            this.inputDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputDataTable.Location = new System.Drawing.Point(12, 58);
            this.inputDataTable.Name = "inputDataTable";
            this.inputDataTable.Size = new System.Drawing.Size(388, 430);
            this.inputDataTable.TabIndex = 1;
            // 
            // corporateDataTable
            // 
            this.corporateDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.corporateDataTable.Location = new System.Drawing.Point(406, 58);
            this.corporateDataTable.Name = "corporateDataTable";
            this.corporateDataTable.Size = new System.Drawing.Size(388, 430);
            this.corporateDataTable.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Корпоративные ресурсы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Входные данные:";
            // 
            // corporateUrlAdd
            // 
            this.corporateUrlAdd.Location = new System.Drawing.Point(800, 84);
            this.corporateUrlAdd.Name = "corporateUrlAdd";
            this.corporateUrlAdd.Size = new System.Drawing.Size(163, 23);
            this.corporateUrlAdd.TabIndex = 5;
            this.corporateUrlAdd.Text = "Добавить";
            this.corporateUrlAdd.UseVisualStyleBackColor = true;
            this.corporateUrlAdd.Click += new System.EventHandler(this.corporateUrlAdd_Click);
            // 
            // corporateUrlDelete
            // 
            this.corporateUrlDelete.Location = new System.Drawing.Point(977, 84);
            this.corporateUrlDelete.Name = "corporateUrlDelete";
            this.corporateUrlDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.corporateUrlDelete.Size = new System.Drawing.Size(163, 23);
            this.corporateUrlDelete.TabIndex = 6;
            this.corporateUrlDelete.Text = "Удалить";
            this.corporateUrlDelete.UseVisualStyleBackColor = true;
            this.corporateUrlDelete.Click += new System.EventHandler(this.corporateUrlDelete_Click);
            // 
            // corporateUrlTextField
            // 
            this.corporateUrlTextField.Location = new System.Drawing.Point(800, 58);
            this.corporateUrlTextField.Name = "corporateUrlTextField";
            this.corporateUrlTextField.Size = new System.Drawing.Size(340, 20);
            this.corporateUrlTextField.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(797, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "URL:";
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(800, 114);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.Size = new System.Drawing.Size(340, 374);
            this.resultText.TabIndex = 9;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 500);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.corporateUrlTextField);
            this.Controls.Add(this.corporateUrlDelete);
            this.Controls.Add(this.corporateUrlAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.corporateDataTable);
            this.Controls.Add(this.inputDataTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Статистика посещений сайтов сотрудниками";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corporateDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фааToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyzeMenuButton;
        private System.Windows.Forms.ToolStripMenuItem faqMenuButton;
        private System.Windows.Forms.DataGridView inputDataTable;
        private System.Windows.Forms.DataGridView corporateDataTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button corporateUrlAdd;
        private System.Windows.Forms.Button corporateUrlDelete;
        private System.Windows.Forms.TextBox corporateUrlTextField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem importMenuButton;
        private System.Windows.Forms.TextBox resultText;
    }
}

