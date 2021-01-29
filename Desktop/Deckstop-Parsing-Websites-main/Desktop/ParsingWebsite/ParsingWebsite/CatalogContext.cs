using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace ParsingWebsite
{
    class CatalogContext : DbContext
    {
        public CatalogContext()
            : base("DbConnection")
        { }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Characteristic> Characteristics { get; set; }
    }
}
