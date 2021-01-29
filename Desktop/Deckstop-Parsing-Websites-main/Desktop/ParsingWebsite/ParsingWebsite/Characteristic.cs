using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ParsingWebsite
{
    class Characteristic
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public Characteristic()
        {
            Articles = new List<Article>();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
