using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationWebShopDemo.Models
{
    public class HDDs
    {

        [Key]
        public int hdd_id { get; set; }

        [Required]
        public string hdd_capacity { get; set; }

        [Required]
        public decimal hdd_price { get; set; }
    }
}
