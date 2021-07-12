using ContactsWebApp.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactsWebApp.Models
{
    public class HomeViewModel
    {
        public DateTime DateTime { get; set; }
        public int Id { get; set; }
        public bool IsSqlSelected { get; set; }
        public bool IsJsonSelected { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Address cannot be longer than 40 characters.")]
        public string Address { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Name cannot be longer than 40 characters.")]
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

        private List<ContactDataModel> _SearchResult;
        public List<ContactDataModel> SearchResult 
        {
            get
            {
                if (_SearchResult == null)
                    _SearchResult = new List<ContactDataModel>();
                return _SearchResult;
            }
            set 
            {
                _SearchResult = value;
            } 
        }
    }
}
