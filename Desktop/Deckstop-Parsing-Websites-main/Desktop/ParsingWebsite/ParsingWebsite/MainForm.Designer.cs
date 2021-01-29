namespace ParsingWebsite
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
            this.buttonWritingToDatabase = new System.Windows.Forms.Button();
            this.linksListBox = new System.Windows.Forms.ListBox();
            this.buttonDisplayDatabase = new System.Windows.Forms.Button();
            this.buttonGenerationLinks = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonWritingToDatabase
            // 
            this.buttonWritingToDatabase.Location = new System.Drawing.Point(10, 266);
            this.buttonWritingToDatabase.Name = "buttonWritingToDatabase";
            this.buttonWritingToDatabase.Size = new System.Drawing.Size(149, 23);
            this.buttonWritingToDatabase.TabIndex = 0;
            this.buttonWritingToDatabase.Text = "Записать в базу данных";
            this.buttonWritingToDatabase.UseVisualStyleBackColor = true;
            this.buttonWritingToDatabase.Click += new System.EventHandler(this.buttonWritingToDatabase_Click);
            // 
            // linksListBox
            // 
            this.linksListBox.FormattingEnabled = true;
            this.linksListBox.Location = new System.Drawing.Point(8, 65);
            this.linksListBox.Name = "linksListBox";
            this.linksListBox.Size = new System.Drawing.Size(553, 186);
            this.linksListBox.TabIndex = 1;
            this.linksListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.linksListBox_MouseDoubleClick);
            // 
            // buttonDisplayDatabase
            // 
            this.buttonDisplayDatabase.Location = new System.Drawing.Point(12, 320);
            this.buttonDisplayDatabase.Name = "buttonDisplayDatabase";
            this.buttonDisplayDatabase.Size = new System.Drawing.Size(120, 23);
            this.buttonDisplayDatabase.TabIndex = 2;
            this.buttonDisplayDatabase.Text = "Открыть базу";
            this.buttonDisplayDatabase.UseVisualStyleBackColor = true;
            this.buttonDisplayDatabase.Click += new System.EventHandler(this.buttonDisplayDatabase_Click);
            // 
            // buttonGenerationLinks
            // 
            this.buttonGenerationLinks.Location = new System.Drawing.Point(8, 36);
            this.buttonGenerationLinks.Name = "buttonGenerationLinks";
            this.buttonGenerationLinks.Size = new System.Drawing.Size(151, 23);
            this.buttonGenerationLinks.TabIndex = 4;
            this.buttonGenerationLinks.Text = "Вывести список ссылок";
            this.buttonGenerationLinks.UseVisualStyleBackColor = true;
            this.buttonGenerationLinks.Click += new System.EventHandler(this.buttonGenerationLinks_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(165, 266);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(149, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(454, 320);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(107, 23);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(508, 12);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(53, 20);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 355);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonGenerationLinks);
            this.Controls.Add(this.buttonDisplayDatabase);
            this.Controls.Add(this.linksListBox);
            this.Controls.Add(this.buttonWritingToDatabase);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWritingToDatabase;
        private System.Windows.Forms.ListBox linksListBox;
        private System.Windows.Forms.Button buttonDisplayDatabase;
        private System.Windows.Forms.Button buttonGenerationLinks;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonHelp;
    }
}

