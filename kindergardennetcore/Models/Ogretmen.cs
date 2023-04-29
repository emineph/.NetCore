using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kindergardennetcore.Models
{
    public class Ogretmen
    {
        [Key]
        public int OgretmenNo { get; set; }

        [Required]
        [StringLength(50)]
        public string OgretmenAdi { get; set; }

        [Required]
        [StringLength(2)]
        public string OgretmenSinifi { get; set; }

        [Required]
        [StringLength(2)]
        public string OgretmenYasi { get; set; }

        [Required]
        [StringLength(15)]
        public string OgretmenMaas{ get; set; }
    }
}
