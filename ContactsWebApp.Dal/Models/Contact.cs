using System;
using System.Collections.Generic;

#nullable disable

namespace ContactsWebApp.Dal.Models
{
    public partial class Contact
    {
        public int ContactId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateTime { get; set; }
    }
}
