using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationWebShopDemo.Models
{
    public class CPUs
    {
        [Key]
        public int cpu_id { get; set; }

        [Required]
        public string cpu_model { get; set; }

        [Required]
        public int cpu_quantity { get; set; }

        [Required]
        public decimal cpu_price { get; set; }
    }
}
