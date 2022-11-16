using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class MContext:DbContext
    {
        public virtual DbSet<About> abouts { get; set; }
        public virtual DbSet<Category> categories {get; set; }
        public virtual DbSet<Contact> contacts { get; set; }
        public virtual DbSet<Content> contents { get; set; }
        public virtual DbSet<Heading> headings { get; set; }
        public virtual DbSet<Writer> writers { get; set; }

    }
}

