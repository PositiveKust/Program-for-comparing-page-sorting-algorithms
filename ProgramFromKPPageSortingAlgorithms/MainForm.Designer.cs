
namespace ProgramFromKPPageSortingAlgorithms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.checkedListBoxAlgoritmsSortingPage = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NumberofPageBlocks = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.temptoolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.общееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вводИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикСравненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTable = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownNumNewPage = new System.Windows.Forms.NumericUpDown();
            this.buttonnewPage = new System.Windows.Forms.Button();
            this.timerNRY = new System.Windows.Forms.Timer(this.components);
            this.checkboxhandNRU = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDowndifferentpages = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownmaxpagesblock = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.checkboxrandomNRU = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumberofPageBlocks)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumNewPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowndifferentpages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownmaxpagesblock)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxAlgoritmsSortingPage
            // 
            this.checkedListBoxAlgoritmsSortingPage.FormattingEnabled = true;
            this.checkedListBoxAlgoritmsSortingPage.Items.AddRange(new object[] {
            "LRU",
            "NRU",
            "FIFO",
            "Часы",
            "Вторая попытка"});
            this.checkedListBoxAlgoritmsSortingPage.Location = new System.Drawing.Point(187, 333);
            this.checkedListBoxAlgoritmsSortingPage.Name = "checkedListBoxAlgoritmsSortingPage";
            this.checkedListBoxAlgoritmsSortingPage.Size = new System.Drawing.Size(156, 106);
            this.checkedListBoxAlgoritmsSortingPage.TabIndex = 1;
            this.checkedListBoxAlgoritmsSortingPage.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxAlgoritmsSortingPage_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберете \r\nалгоритмы сортировки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите количество\r\nстраничных блоков:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NumberofPageBlocks
            // 
            this.NumberofPageBlocks.Location = new System.Drawing.Point(356, 350);
            this.NumberofPageBlocks.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumberofPageBlocks.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumberofPageBlocks.Name = "NumberofPageBlocks";
            this.NumberofPageBlocks.Size = new System.Drawing.Size(140, 22);
            this.NumberofPageBlocks.TabIndex = 5;
            this.NumberofPageBlocks.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumberofPageBlocks.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temptoolstrip,
            this.вводИзФайлаToolStripMenuItem,
            this.графикСравненияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 30);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // temptoolstrip
            // 
            this.temptoolstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общееToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.обновитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.temptoolstrip.Name = "temptoolstrip";
            this.temptoolstrip.Size = new System.Drawing.Size(71, 26);
            this.temptoolstrip.Text = "Общее";
            // 
            // общееToolStripMenuItem
            // 
            this.общееToolStripMenuItem.Name = "общееToolStripMenuItem";
            this.общееToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.общееToolStripMenuItem.Text = "О программе";
            this.общееToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click_1);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.оПрограммеToolStripMenuItem.Text = "Отключить оповещения";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click_1);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // вводИзФайлаToolStripMenuItem
            // 
            this.вводИзФайлаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.вводИзФайлаToolStripMenuItem.Name = "вводИзФайлаToolStripMenuItem";
            this.вводИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.вводИзФайлаToolStripMenuItem.Text = "Работа с файлами";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // графикСравненияToolStripMenuItem
            // 
            this.графикСравненияToolStripMenuItem.Name = "графикСравненияToolStripMenuItem";
            this.графикСравненияToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.графикСравненияToolStripMenuItem.Text = "График сравнения";
            this.графикСравненияToolStripMenuItem.Click += new System.EventHandler(this.графикСравненияToolStripMenuItem_Click);
            // 
            // MainTable
            // 
            this.MainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTable.Location = new System.Drawing.Point(0, 30);
            this.MainTable.Name = "MainTable";
            this.MainTable.ReadOnly = true;
            this.MainTable.RowHeadersWidth = 51;
            this.MainTable.RowTemplate.Height = 24;
            this.MainTable.Size = new System.Drawing.Size(722, 263);
            this.MainTable.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 51);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введите номер\r\nстраницы, к которой\r\nхотите обратиться:";
            // 
            // numericUpDownNumNewPage
            // 
            this.numericUpDownNumNewPage.Location = new System.Drawing.Point(509, 350);
            this.numericUpDownNumNewPage.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownNumNewPage.Name = "numericUpDownNumNewPage";
            this.numericUpDownNumNewPage.Size = new System.Drawing.Size(140, 22);
            this.numericUpDownNumNewPage.TabIndex = 10;
            // 
            // buttonnewPage
            // 
            this.buttonnewPage.Location = new System.Drawing.Point(355, 391);
            this.buttonnewPage.Name = "buttonnewPage";
            this.buttonnewPage.Size = new System.Drawing.Size(140, 48);
            this.buttonnewPage.TabIndex = 11;
            this.buttonnewPage.Text = "Выбор страницы";
            this.buttonnewPage.UseVisualStyleBackColor = true;
            this.buttonnewPage.Click += new System.EventHandler(this.buttonnewPage_Click);
            // 
            // timerNRY
            // 
            this.timerNRY.Interval = 20;
            this.timerNRY.Tick += new System.EventHandler(this.timerNRY_Tick);
            // 
            // checkboxhandNRU
            // 
            this.checkboxhandNRU.AutoSize = true;
            this.checkboxhandNRU.Location = new System.Drawing.Point(509, 418);
            this.checkboxhandNRU.Name = "checkboxhandNRU";
            this.checkboxhandNRU.Size = new System.Drawing.Size(132, 38);
            this.checkboxhandNRU.TabIndex = 14;
            this.checkboxhandNRU.Text = "Страница была\r\nизменена";
            this.checkboxhandNRU.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 34);
            this.label4.TabIndex = 15;
            this.label4.Text = "Введите количество\r\nразличных страниц:";
            // 
            // numericUpDowndifferentpages
            // 
            this.numericUpDowndifferentpages.Location = new System.Drawing.Point(15, 426);
            this.numericUpDowndifferentpages.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDowndifferentpages.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDowndifferentpages.Name = "numericUpDowndifferentpages";
            this.numericUpDowndifferentpages.Size = new System.Drawing.Size(140, 22);
            this.numericUpDowndifferentpages.TabIndex = 16;
            this.numericUpDowndifferentpages.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDowndifferentpages.ValueChanged += new System.EventHandler(this.numericUpDowndifferentpages_ValueChanged);
            // 
            // numericUpDownmaxpagesblock
            // 
            this.numericUpDownmaxpagesblock.Location = new System.Drawing.Point(15, 350);
            this.numericUpDownmaxpagesblock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownmaxpagesblock.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownmaxpagesblock.Name = "numericUpDownmaxpagesblock";
            this.numericUpDownmaxpagesblock.Size = new System.Drawing.Size(140, 22);
            this.numericUpDownmaxpagesblock.TabIndex = 18;
            this.numericUpDownmaxpagesblock.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownmaxpagesblock.ValueChanged += new System.EventHandler(this.numericUpDownmaxpagesblock_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 51);
            this.label5.TabIndex = 17;
            this.label5.Text = "Введите максимальное\r\nколичество страничных\r\nблоков:";
            // 
            // checkboxrandomNRU
            // 
            this.checkboxrandomNRU.AutoSize = true;
            this.checkboxrandomNRU.Location = new System.Drawing.Point(509, 378);
            this.checkboxrandomNRU.Name = "checkboxrandomNRU";
            this.checkboxrandomNRU.Size = new System.Drawing.Size(217, 38);
            this.checkboxrandomNRU.TabIndex = 19;
            this.checkboxrandomNRU.Text = "Случайно определять\r\nстатус изменения страницы";
            this.checkboxrandomNRU.UseVisualStyleBackColor = true;
            this.checkboxrandomNRU.CheckedChanged += new System.EventHandler(this.checkboxrandomNRU_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 460);
            this.Controls.Add(this.checkboxrandomNRU);
            this.Controls.Add(this.numericUpDownmaxpagesblock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDowndifferentpages);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkboxhandNRU);
            this.Controls.Add(this.buttonnewPage);
            this.Controls.Add(this.numericUpDownNumNewPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MainTable);
            this.Controls.Add(this.NumberofPageBlocks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxAlgoritmsSortingPage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Программа сравнения алгоритмов замещения страниц";
            ((System.ComponentModel.ISupportInitialize)(this.NumberofPageBlocks)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumNewPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowndifferentpages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownmaxpagesblock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBoxAlgoritmsSortingPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown NumberofPageBlocks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вводИзФайлаToolStripMenuItem;
        private System.Windows.Forms.DataGridView MainTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownNumNewPage;
        private System.Windows.Forms.Button buttonnewPage;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Timer timerNRY;
        private System.Windows.Forms.CheckBox checkboxhandNRU;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem графикСравненияToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDowndifferentpages;
        private System.Windows.Forms.NumericUpDown numericUpDownmaxpagesblock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkboxrandomNRU;
        private System.Windows.Forms.ToolStripMenuItem temptoolstrip;
        private System.Windows.Forms.ToolStripMenuItem общееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

