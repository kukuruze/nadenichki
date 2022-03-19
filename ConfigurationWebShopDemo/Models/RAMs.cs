using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationWebShopDemo.Models
{
    public class RAMs
    {
        [Key]
        public int ram_id { get; set; }

        [Required]
        public string ram_capacity { get; set; }

        [Required]
        public int ram_quantity { get; set; }

        [Required]
        public decimal ram_price { get; set; }
    }
}
