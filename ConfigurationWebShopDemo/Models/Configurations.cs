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
        public int Configuration_Id { get; set; }

        [Required]
        public string Mother_Board { get; set; }

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
        public string Sound_Card { get; set; }

        [Required]
        public string WWAN_Card { get; set; }

        [Required]
        public string Computer_Case { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
