using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuBookStorev5.Models
{
    public  class Author
    {
        [Key]

        public string AuthorID { get; set; }
        public string AuthorName { get; set; }
        
        
    }
}
