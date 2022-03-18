using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationWebShopDemo.Models
{
    public class SSDs
    {
        [Key]
        public int ssd_id { get; set; }

        [Required]
        public string ssd_capacity { get; set; }

        [Required]
        public decimal ssd_price { get; set; }
    }
}
