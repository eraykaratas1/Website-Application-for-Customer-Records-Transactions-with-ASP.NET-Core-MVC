using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusteriWebProject.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [Column(TypeName ="Varchar(20)")]
        public string AdminAd { get; set; }

        [Column(TypeName = "int")]
        public int Sifre { get; set; }



    }
}
