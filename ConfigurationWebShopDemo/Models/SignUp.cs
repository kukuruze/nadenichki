using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationWebShopDemo.Models
{
    public class SignUp
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        //[RegularExpression(@"(?=.\d)(?=.[A-Za-z]).{5,}", ErrorMessage = "Your password must be at least 5 characters long and contain at least 1 letter and 1 number.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
