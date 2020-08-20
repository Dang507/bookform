using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuBookStorev5.Models;

namespace VuBookStorev5
{
    public partial class BookDBContext : DbContext
    {
        public BookDBContext() : base("Book4")
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookDetail> BookDeatails { get; set; }
        public DbSet<BookTitle> BookTitles { get; set; }
        public DbSet<Nxb> Nxbs { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
