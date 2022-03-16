using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationWebShopDemo.Models
{
    public class Configurations
    {
        [Key]
        public int ConfigurationId { get; set; }

        [Required]
        public string MotherBoard { get; set; }

        [Required]
        public string SSD { get; set; }

        [Required]
        public string HDD { get; set; }

        [Required]
        public string RAM { get; set; }

        [Required]
        public string CPU { get; set; }

        [Required]
        public string GPU { get; set; }
        [Required]
        public string SoundCard { get; set; }
        [Required]
        public string WWANCard { get; set; }
        [Required]
        public string Computer_Case { get; set; }
        [Required]
        public string Price { get; set; }
    }
}
