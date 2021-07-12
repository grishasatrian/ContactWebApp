using ContactsWebApp.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactsWebApp.Models
{
    public class ContactViewModel
    {
        public bool IsSqlSelected { get; set; }
        public bool IsJsonSelected { get; set; }
        public ContactDataModel ContactItem { get; set; }
        
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
