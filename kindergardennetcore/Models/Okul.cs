using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kindergardennetcore.Models
{
    public class Okul
    {
        [Key]
        public int OkulNo { get; set; }

        [Required]
        [StringLength(30)]
        public string OgrenciSayisi { get; set; }

        [Required]
        [StringLength(30)]
        public string OgretmenSayisi { get; set; }

        [Required]
        [StringLength(30)]
        public string SubeSayisi { get; set; }

    }
}
