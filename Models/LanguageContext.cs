using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class LanguageContext : DbContext
    {
        public DbSet<Language> languages { get; set; }
    }
}