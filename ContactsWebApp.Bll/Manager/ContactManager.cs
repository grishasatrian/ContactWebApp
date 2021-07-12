using ContactsWebApp.Dal.Models;
using ContactsWebApp.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text.Json.Serialization;
using ContactsWebApp.Dal;
using ContactsWebApp.Dal.Manager;

namespace ContactsWebApp.Bll.Manager
{
    public class ContactManager
    {
        // Ctor for data access
        private IContactDataAccess _dataAccess;
        public ContactManager(bool IsSqlSelected = true)
        {
            if(IsSqlSelected)
            {
                _dataAccess = new SqlDataAccess();
            }
            else
            {
                _dataAccess = new JsonDataAccess();
            }
        }
        public List<ContactDataModel> GetContacts(string fullName, string phoneNumber, string email, string address)
        {
            return _dataAccess.GetContacts(fullName, phoneNumber, email, address);
        }
        public ContactDataModel AddEditContacts(int id, string fullName, string phoneNumber, string email, string address)
        {
            return _dataAccess.AddEditContacts(id, fullName, phoneNumber, email, address);
        }

        public ContactDataModel GetContactById(int id)
        {
            return _dataAccess.GetContactById(id);
        }
        public void RemoveContact(int contactId)
        {
            _dataAccess.RemoveContact(contactId);
        }
    }
}
