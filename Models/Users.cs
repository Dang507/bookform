using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuBookStorev5.Models
{
    public  class Users
    {
        [Key]
        [Required]
        public string UserID { get; set; }
       
        public string UserName { get; set; }


        public int UserPhone { get; set; }

        public DateTime UngayDK { get; set; }

        public DateTime UngayHetHan { get; set; }


        public int Zipcode { get; set; }


        public string UserEmail { get; set; }
       



    }
}
