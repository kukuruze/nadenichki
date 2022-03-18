using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConfigurationWebShopDemo.Models
{
    public class GPUs
    {
        [Key]
        public int gpu_id { get; set; }

        [Required]
        public string gpu_model { get; set; }

        [Required]
        public decimal gpu_price { get; set; }
    }
}
