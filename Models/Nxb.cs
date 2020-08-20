using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuBookStorev5.Models
{
    public partial class Nxb
    {
        [Key]


        public string NxbID { get; set; }
        

        public string NxbName { get; set; }
    }
}
