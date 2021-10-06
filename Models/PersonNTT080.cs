﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenTamThanh080.Models
{
    public class PersonNTT080
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string PersonId { get; set; }
        [Required]
        [StringLength(50)]
        public string PersonName { get; set; }
    }
}
