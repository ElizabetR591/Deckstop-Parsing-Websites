using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace ParsingWebsite
{
    class Article
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? CharacteristicId { get; set; }
        public virtual Characteristic Characteristic { get; set; }
    }
}
