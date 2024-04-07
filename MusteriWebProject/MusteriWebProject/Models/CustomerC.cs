using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusteriWebProject.Models
{
    public class CustomerC
    {
        [Key]
        public int CustKey { get; set; }

        [Column(TypeName = "int")]
        public int MusteriNo { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Adı { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Soyadı { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Kaynak { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string KayitTarihiBaslangici { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string KayitTarihiBitisi { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Kampanya { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string GorusmeSonucu { get; set; }

        [Column(TypeName = "bigint")]
        public int TelefonNo { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string AramaTarihi { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Temsilci { get; set; }


    }
}
