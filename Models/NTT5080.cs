using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenTamThanh080.Models
{
    public class NTT5080
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string NVNId { get; set; }
        [Required]
        [StringLength(20)]
        public string NVNName { get; set; }
        public Boolean NVNGender { get; set; }
    }
}
