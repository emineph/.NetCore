using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kindergardennetcore.Models
{
    public class Ders
    {
        [Key]
        public int DersNo { get; set; }

        [Required]
        [StringLength(50)]
        public string DersAdi { get; set; }

        [Required]
        [StringLength(10)]
        public string DersSaati { get; set; }

        [Required]
        [StringLength(15)]
        public string DersGunu { get; set; }

        [Required]
        [StringLength(50)]
        public string DersKonu { get; set; }

    }
}
