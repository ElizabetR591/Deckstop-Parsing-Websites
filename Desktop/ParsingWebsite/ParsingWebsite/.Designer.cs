namespace ParsingWebsite
{
    partial class DisplayingData
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
            this.dataGridViewArticles = new System.Windows.Forms.DataGridView();
            this.dataGridViewCharacteristics = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCharacteristics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewArticles
            // 
            this.dataGridViewArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticles.Location = new System.Drawing.Point(12, 67);
            this.dataGridViewArticles.Name = "dataGridViewArticles";
            this.dataGridViewArticles.ReadOnly = true;
            this.dataGridViewArticles.RowTemplate.ReadOnly = true;
            this.dataGridViewArticles.Size = new System.Drawing.Size(362, 229);
            this.dataGridViewArticles.TabIndex = 0;
            // 
            // dataGridViewCharacteristics
            // 
            this.dataGridViewCharacteristics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCharacteristics.Location = new System.Drawing.Point(416, 67);
            this.dataGridViewCharacteristics.Name = "dataGridViewCharacteristics";
            this.dataGridViewCharacteristics.ReadOnly = true;
            this.dataGridViewCharacteristics.RowTemplate.ReadOnly = true;
            this.dataGridViewCharacteristics.Size = new System.Drawing.Size(359, 229);
            this.dataGridViewCharacteristics.TabIndex = 1;
            this.dataGridViewCharacteristics.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(650, 402);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(116, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Закрыть ";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(713, 26);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(53, 20);
            this.buttonHelp.TabIndex = 9;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // DisplayingData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewCharacteristics);
            this.Controls.Add(this.dataGridViewArticles);
            this.Name = "DisplayingData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayingData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCharacteristics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewArticles;
        public System.Windows.Forms.DataGridView dataGridViewCharacteristics;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonHelp;
    }
}