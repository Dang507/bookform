using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuBookStorev5.Models
{
    public partial class BookDetail
    {
        [Key]
        public string BookID { get; set; }
        public Author AuthorID { get; set; }
       
        public  Users UserID { get; set; }
        public BookTitle BT_ID {get;set;}
        public Nxb NxbID { get; set; }
        public string BookName { get; set; }
    }
}
