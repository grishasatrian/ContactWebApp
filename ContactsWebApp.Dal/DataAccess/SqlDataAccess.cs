using ContactsWebApp.Dal;
using ContactsWebApp.Dal.Models;
using ContactsWebApp.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactsWebApp.Dal.Manager
{
    public class SqlDataAccess : IContactDataAccess
    {
        public ContactDataModel AddEditContacts(int id, string fullName, string phoneNumber, string email, string address)
        {
            ContactDataModel returnItem = new ContactDataModel();
            using (ContactListContext context = new ContactListContext())
            {
                var entity = new Contact();
                if (id <= 0)
                {
                    entity.Address = address;
                    entity.DateTime = DateTime.Now;
                    entity.Email = email;
                    entity.FullName = fullName;
                    entity.PhoneNumber = phoneNumber;
                    context.Contacts.Add(entity);
                }
                else
                {
                    entity = context.Contacts.FirstOrDefault(f => f.ContactId == id);
                    if (entity != null)
                    {
                        entity.Address = address;
                        entity.DateTime = DateTime.Now;
                        entity.Email = email;
                        entity.FullName = fullName;
                        entity.PhoneNumber = phoneNumber;
                    }
                }
                context.SaveChanges();
                returnItem.Address = entity.Address;
                returnItem.ContactId = entity.ContactId;
                returnItem.DateTime = entity.DateTime;
                returnItem.Email = entity.Email;
                returnItem.FullName = entity.FullName;
                returnItem.PhoneNumber = entity.PhoneNumber;
            }
            return returnItem;
        }

        public ContactDataModel GetContactById(int id)
        {
            ContactDataModel returnItem = new ContactDataModel();
            using (ContactListContext context = new ContactListContext())
            {
                var entity = context.Contacts.FirstOrDefault(f => f.ContactId == id);
                returnItem.Address = entity.Address;
                returnItem.ContactId = entity.ContactId;
                returnItem.DateTime = entity.DateTime;
                returnItem.Email = entity.Email;
                returnItem.FullName = entity.FullName;
                returnItem.PhoneNumber = entity.PhoneNumber;
            }
            return returnItem;
        }

        public List<ContactDataModel> GetContacts(string fullName, string phoneNumber, string email, string address)
        {
            List<ContactDataModel> returnList = new List<ContactDataModel>();
            using (ContactListContext context = new ContactListContext())
            {
                returnList = context.Contacts.Where(w => (fullName == null || w.FullName == fullName) &&
                (phoneNumber == null || w.PhoneNumber == phoneNumber) &&
                (email == null || w.Email == email) &&
                (address == null || w.Address == address)
                ).Select(s => new ContactDataModel
                {
                    Address = s.Address,
                    ContactId = s.ContactId,
                    DateTime = s.DateTime,
                    Email = s.Email,
                    FullName = s.FullName,
                    PhoneNumber = s.PhoneNumber
                }
                ).ToList();
            }
            return returnList;
        }
        public void RemoveContact(int contactId)
        {
            using (ContactListContext context = new ContactListContext())
            {
                var returnList = context.Contacts.FirstOrDefault(f => f.ContactId == contactId);
                if (returnList != null)
                {
                    context.Contacts.Remove(returnList);
                    context.SaveChanges();
                }
            }
        }
    }
}