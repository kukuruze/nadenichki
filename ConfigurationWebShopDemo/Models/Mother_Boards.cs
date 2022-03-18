using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationWebShopDemo.Models
{
    public class Mother_Boards
    {
        [Key]
        public int mother_board_id { get; set; }

        [Required]
        public string mother_board_model { get; set; }

        [Required]
        public decimal mother_board_price { get; set; }
    }
}
