using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ContactsWebApp.DataModel
{
    public class ContactDataModel
    {
        public int ContactId { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Full Name number cannot be longer than 40 characters.")]
        [RegularExpression("[a-zA-Z][a-zA-Z ]+", ErrorMessage = "Only alphabet")]
        public string FullName { get; set; }

        [Required]
        [StringLength(12, ErrorMessage = "Phone number cannot be longer than 12 characters.")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Email cannot be longer than 30 characters.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Address cannot be longer than 40 characters.")]
        public string Address { get; set; }
        public DateTime DateTime { get; set; }
    }
}
