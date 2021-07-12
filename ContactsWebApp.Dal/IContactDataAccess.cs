using ContactsWebApp.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsWebApp.Dal
{
    public interface IContactDataAccess
    {
        List<ContactDataModel> GetContacts(string fullName, string phoneNumber, string email, string address);
        ContactDataModel AddEditContacts(int id, string fullName, string phoneNumber, string email, string address);
        ContactDataModel GetContactById(int id);
        void RemoveContact(int contactId);
    }
}
