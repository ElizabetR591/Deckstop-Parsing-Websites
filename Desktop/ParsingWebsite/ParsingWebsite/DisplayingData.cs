using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParsingWebsite
{
    public partial class DisplayingData : Form
    {
        public DisplayingData()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string pattern = @"http:.*";
            var linkColumn = dataGridViewCharacteristics.CurrentCell.Value;
            if (Regex.IsMatch(linkColumn.ToString(), pattern))
            System.Diagnostics.Process.Start(linkColumn.ToString());
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("Для того, чтобы открыть изображение, дважды нажмите на ссылку, находящуюся в столбце Image, левой кнопкой мыши");
        }
    }
}
