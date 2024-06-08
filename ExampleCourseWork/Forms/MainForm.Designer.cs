namespace ExampleCourseWork.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предварительныйпросмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectionToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.содержаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.индексToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.LanguageTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultList = new System.Windows.Forms.ListBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.EditBookButton = new System.Windows.Forms.Button();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.MainPageButton = new System.Windows.Forms.Button();
            this.AddCollectionButton = new System.Windows.Forms.Button();
            this.LibrarianButton = new System.Windows.Forms.Button();
            this.DeleteCollectionButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.collectionToolStripComboBox,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.toolStripSeparator,
            this.сохранитьToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.печатьToolStripMenuItem,
            this.предварительныйпросмотрToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 28);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripMenuItem.Image")));
            this.создатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.создатьToolStripMenuItem.Text = "&Створити";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.открытьToolStripMenuItem.Text = "&Відкрити";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(241, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.сохранитьToolStripMenuItem.Text = "&Зберегти";
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.SaveAsToolStripMenuItem.Text = "Зберегти &як";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(241, 6);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("печатьToolStripMenuItem.Image")));
            this.печатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.печатьToolStripMenuItem.Text = "&Друкувати";
            // 
            // предварительныйпросмотрToolStripMenuItem
            // 
            this.предварительныйпросмотрToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("предварительныйпросмотрToolStripMenuItem.Image")));
            this.предварительныйпросмотрToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.предварительныйпросмотрToolStripMenuItem.Name = "предварительныйпросмотрToolStripMenuItem";
            this.предварительныйпросмотрToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.предварительныйпросмотрToolStripMenuItem.Text = "Попередній пере&гляд";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(241, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.ExitToolStripMenuItem.Text = "Ви&хід";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // collectionToolStripComboBox
            // 
            this.collectionToolStripComboBox.Name = "collectionToolStripComboBox";
            this.collectionToolStripComboBox.Size = new System.Drawing.Size(121, 28);
            this.collectionToolStripComboBox.Text = "Колекції";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.содержаниеToolStripMenuItem,
            this.индексToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.toolStripSeparator5,
            this.опрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.справкаToolStripMenuItem.Text = "Допо&мога";
            // 
            // содержаниеToolStripMenuItem
            // 
            this.содержаниеToolStripMenuItem.Name = "содержаниеToolStripMenuItem";
            this.содержаниеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.содержаниеToolStripMenuItem.Text = "&Зміст";
            // 
            // индексToolStripMenuItem
            // 
            this.индексToolStripMenuItem.Name = "индексToolStripMenuItem";
            this.индексToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.индексToolStripMenuItem.Text = "&Індекс";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.поискToolStripMenuItem.Text = "&Пошук";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(221, 6);
            // 
            // опрограммеToolStripMenuItem
            // 
            this.опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            this.опрограммеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.опрограммеToolStripMenuItem.Text = "&Про програму...";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.IdTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.LanguageTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.GenreTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.YearTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AuthorTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TitleTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(40, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 170);
            this.panel1.TabIndex = 1;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(97, 9);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(413, 22);
            this.IdTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(22, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Номер";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(395, 121);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(115, 35);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "Пошук";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // LanguageTextBox
            // 
            this.LanguageTextBox.Location = new System.Drawing.Point(97, 121);
            this.LanguageTextBox.Name = "LanguageTextBox";
            this.LanguageTextBox.Size = new System.Drawing.Size(231, 22);
            this.LanguageTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Мова";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(327, 93);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(183, 22);
            this.GenreTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(257, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Жанр";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(97, 93);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(136, 22);
            this.YearTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Рік";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(97, 65);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(413, 22);
            this.AuthorTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Автор";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(97, 37);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(413, 22);
            this.TitleTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва";
            // 
            // ResultList
            // 
            this.ResultList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResultList.DataSource = this.bookBindingSource;
            this.ResultList.DisplayMember = "Title";
            this.ResultList.FormattingEnabled = true;
            this.ResultList.ItemHeight = 16;
            this.ResultList.Location = new System.Drawing.Point(40, 245);
            this.ResultList.Name = "ResultList";
            this.ResultList.Size = new System.Drawing.Size(545, 196);
            this.ResultList.TabIndex = 2;
            this.ResultList.DoubleClick += new System.EventHandler(this.ResultList_DoubleClick);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(ExampleCourseWork.Models.Book);
            // 
            // bookBindingSource3
            // 
            this.bookBindingSource3.DataSource = typeof(ExampleCourseWork.Models.Book);
            // 
            // EditBookButton
            // 
            this.EditBookButton.BackColor = System.Drawing.Color.Gainsboro;
            this.EditBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditBookButton.Location = new System.Drawing.Point(607, 110);
            this.EditBookButton.Name = "EditBookButton";
            this.EditBookButton.Size = new System.Drawing.Size(213, 56);
            this.EditBookButton.TabIndex = 3;
            this.EditBookButton.Text = "Редагувати книгу";
            this.EditBookButton.UseVisualStyleBackColor = false;
            this.EditBookButton.Click += new System.EventHandler(this.EditBookButton_Click);
            // 
            // AddBookButton
            // 
            this.AddBookButton.BackColor = System.Drawing.Color.Gainsboro;
            this.AddBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBookButton.Location = new System.Drawing.Point(607, 172);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(213, 56);
            this.AddBookButton.TabIndex = 4;
            this.AddBookButton.Text = "Додати книгу";
            this.AddBookButton.UseVisualStyleBackColor = false;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // MainPageButton
            // 
            this.MainPageButton.BackColor = System.Drawing.Color.Gainsboro;
            this.MainPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPageButton.Location = new System.Drawing.Point(607, 385);
            this.MainPageButton.Name = "MainPageButton";
            this.MainPageButton.Size = new System.Drawing.Size(213, 56);
            this.MainPageButton.TabIndex = 5;
            this.MainPageButton.Text = "Головна сторінка";
            this.MainPageButton.UseVisualStyleBackColor = false;
            this.MainPageButton.Click += new System.EventHandler(this.MainPageButton_Click);
            // 
            // AddCollectionButton
            // 
            this.AddCollectionButton.BackColor = System.Drawing.Color.Gainsboro;
            this.AddCollectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCollectionButton.Location = new System.Drawing.Point(607, 245);
            this.AddCollectionButton.Name = "AddCollectionButton";
            this.AddCollectionButton.Size = new System.Drawing.Size(213, 56);
            this.AddCollectionButton.TabIndex = 6;
            this.AddCollectionButton.Text = "Створити колекцію";
            this.AddCollectionButton.UseVisualStyleBackColor = false;
            this.AddCollectionButton.Click += new System.EventHandler(this.AddCollectionButton_Click);
            // 
            // LibrarianButton
            // 
            this.LibrarianButton.BackColor = System.Drawing.Color.Gainsboro;
            this.LibrarianButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LibrarianButton.Location = new System.Drawing.Point(607, 42);
            this.LibrarianButton.Name = "LibrarianButton";
            this.LibrarianButton.Size = new System.Drawing.Size(213, 56);
            this.LibrarianButton.TabIndex = 7;
            this.LibrarianButton.Text = "Бібліотекар";
            this.LibrarianButton.UseVisualStyleBackColor = false;
            this.LibrarianButton.Click += new System.EventHandler(this.LibrarianButton_Click);
            // 
            // DeleteCollectionButton
            // 
            this.DeleteCollectionButton.BackColor = System.Drawing.Color.Gainsboro;
            this.DeleteCollectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteCollectionButton.Location = new System.Drawing.Point(607, 307);
            this.DeleteCollectionButton.Name = "DeleteCollectionButton";
            this.DeleteCollectionButton.Size = new System.Drawing.Size(213, 56);
            this.DeleteCollectionButton.TabIndex = 8;
            this.DeleteCollectionButton.Text = "Видалити колекцію";
            this.DeleteCollectionButton.UseVisualStyleBackColor = false;
            this.DeleteCollectionButton.Click += new System.EventHandler(this.DeleteCollectionButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.DeleteCollectionButton);
            this.Controls.Add(this.LibrarianButton);
            this.Controls.Add(this.AddCollectionButton);
            this.Controls.Add(this.MainPageButton);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.EditBookButton);
            this.Controls.Add(this.ResultList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "MainForm";
            this.Text = "Головне вікно";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предварительныйпросмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem содержаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem индексToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox LanguageTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ResultList;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bookBindingSource3;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.Button EditBookButton;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.ToolStripComboBox collectionToolStripComboBox;
        private System.Windows.Forms.Button MainPageButton;
        private System.Windows.Forms.Button AddCollectionButton;
        private System.Windows.Forms.Button LibrarianButton;
        private System.Windows.Forms.Button DeleteCollectionButton;
    }
}