using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class RegisterModel
    {
        [Required (ErrorMessage = "Email should not be empty!")]
        [EmailAddress(ErrorMessage ="Email should be in the Right format")]
        [StringLength(50, ErrorMessage = "Email should be in right format")]
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
