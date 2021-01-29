using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParsingWebsite
{
    public partial class MainForm : Form
    {
        CatalogContext db;
        string links;
        string url;

        public MainForm()
        {
            InitializeComponent();
            db = new CatalogContext();
            db.Articles.Load();
            db.Characteristics.Load();
        }
        private void buttonWritingToDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                if (url != null)
            {
                HtmlWeb webDoc = new HtmlWeb();              
                HtmlAgilityPack.HtmlDocument doc = webDoc.Load(url);
                HtmlNodeCollection parsingList = doc.DocumentNode.SelectNodes(".//img[@title]");

                if (parsingList == null)
                {
                    _ = MessageBox.Show("Невозможно произвести парсинг страницы");
                }

                    foreach (var tag in parsingList)
                    {
                        var parsingStringTitle = tag.GetAttributeValue("title", "Значение не найдено");
                        var parsingStringImage = tag.GetAttributeValue("src", "Значение не найдено");
                        var articleName = " ";
                        var characteristicName = "-";

                        String[] splitName = parsingStringTitle.Split(',', '/');
                        for (int j = 0; j < splitName.Length; j++)
                        {
                            articleName = splitName[0];
                            if ((j > 0) && (splitName.Length == 2))
                            {
                                characteristicName = splitName[j];
                                break;
                            }
                            else if ((j > 0) && (splitName.Length > 2) && (j < splitName.Length - 1))
                                characteristicName = splitName[j] + splitName[j + 1];
                        }
                        Article article = new Article();
                        Characteristic characteristic = new Characteristic();
                        article.Name = articleName;
                        article.CharacteristicId = characteristic.ID;
                        characteristic.Name = characteristicName;
                        characteristic.Image = "http:"+ parsingStringImage;
                        db.Articles.Add(article);
                        db.Characteristics.Add(characteristic);
                        db.SaveChanges();
                    }
                    url = null;              
                    progressBar1.Minimum = 0; 
                    progressBar1.Maximum = 100;                                           
                    progressBar1.Step = 100; 
                    progressBar1.PerformStep();

                    if (progressBar1.Value == progressBar1.Maximum) 
                    { 
                     _ = MessageBox.Show("Добавлено в базу данных!");
                     progressBar1.Value = 0;
                    }                
                }
                else _ = MessageBox.Show("Выберите ссылку!","Ссылка не выбрана");
            }
             catch
            {
                _ = MessageBox.Show("Ошибка", "Errore");
            }
            }
                            
        private void buttonDisplayDatabase_Click(object sender, EventArgs e)
        {
            DisplayingData displayingData = new DisplayingData();
            displayingData.Show();          
            displayingData.dataGridViewArticles.DataSource = db.Articles.Local.ToBindingList();
            displayingData.dataGridViewArticles.Columns["CharacteristicId"].Visible = false;           
            displayingData.dataGridViewCharacteristics.DataSource = db.Characteristics.Local.ToBindingList();
            displayingData.dataGridViewCharacteristics.Columns["Articles"].Visible = false;           
        }
       
            private void buttonGenerationLinks_Click(object sender, EventArgs e)
        {           
            using (StreamReader streamReader = new StreamReader(Application.StartupPath + @"\links.txt"))
            {
                while (true)
                {
                    string temp = streamReader.ReadLine();
                    if (temp == null) break;
                    links += temp;
                }
            }
            String[] link = links.Split(' ');
            for (int i = 0; i < link.Length-1; i++)
            {
                links = link[i];
                linksListBox.Items.Add(links);               
            }
            buttonGenerationLinks.Enabled = false;
        }
     
        private void linksListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            url = linksListBox.SelectedItem.ToString();
            _ = MessageBox.Show("Ссылка выбрана", "OK");
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("Для того, чтобы выбрать ссылку, дважды кликните на ссылку левой кнопкой мыши"); 
        }
    }
}
