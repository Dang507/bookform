using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuBookStorev5.Models
{
    public  class BookDetail
    {
        [Key]
        public string BookID { get; set; }
        [ForeignKey("AuthorID")]     
        public virtual Author Author { get; set; }
        public string AuthorID { get; set; }

        [ForeignKey("UserID")]
        public virtual Users Users { get; set; }
        public string UserID { get; set; }
        

        [ForeignKey("BT_ID")]
        public virtual BookTitle BookTitle { get; set; }
        public string BT_ID { get; set; }
        

        [ForeignKey("NxbID")]
        public virtual Nxb Nxb { get; set; }       
        public string NxbID { get; set; }
        public string BookName { get; set; }
    }
}
