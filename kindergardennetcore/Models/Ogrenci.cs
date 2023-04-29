using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kindergardennetcore.Models
{
    public class Ogrenci
    {
        [Key]
        public int OgrenciNo { get; set; }

        [Required]
        [StringLength(50)]
        public string OgrenciAd { get; set; }

        [Required]
        [StringLength(2)]
        public string OgrenciYas { get; set; }

        [Required]
        [StringLength(5)]
        public string OgrenciSinif { get; set; }

    }
}
