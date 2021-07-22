using ContactsWebApp.Dal;
using ContactsWebApp.Dal.Models;
using ContactsWebApp.DataModel;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Linq;
using System.IO;

namespace ContactsWebApp.Dal.Manager
{
    public class JsonDataAccess : IContactDataAccess
    {
        private const string FileName = "ContactList.grisha";
        private List<ContactDataModel> _ContactsList;     

        public JsonDataAccess()
        {
            if (_ContactsList == null)
            {
                ReadDataJSON();
            }
            if (_ContactsList == null)
            {
                _ContactsList = new List<ContactDataModel>();
            }
        }
       
        private void SaveDataJSON()
        {
            lock (this)
            {
                if (_ContactsList == null || _ContactsList.Count == 0)
                {
                    if(System.IO.File.Exists(FileName))
                    System.IO.File.Delete(FileName);
                }
                else
                {
                    if (System.IO.File.Exists(FileName))
                        System.IO.File.Delete(FileName);
                    DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<ContactDataModel>));
                    using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
                    {
                        formatter.WriteObject(fs, _ContactsList);
                    }
                }
            }
        }
        private void ReadDataJSON()
        {
            if (System.IO.File.Exists(FileName))
            {
                DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<ContactDataModel>));
                using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
                {
                    this._ContactsList = (List<ContactDataModel>)formatter.ReadObject(fs);
                }
            }
        }
        public ContactDataModel AddEditContacts(int id, string fullName, string phoneNumber, string email, string address)
        {
            ContactDataModel dataContactJson;
            if (id <= 0)
            {
                dataContactJson = new ContactDataModel();
                dataContactJson.ContactId = this._ContactsList.Count;
                dataContactJson.DateTime = DateTime.Now;
                dataContactJson.Email = email;
                dataContactJson.FullName = fullName;
                dataContactJson.PhoneNumber = phoneNumber;
                dataContactJson.Address = address;
                _ContactsList.Add(dataContactJson);
            }
            else
            {
                dataContactJson = this._ContactsList.FirstOrDefault(f => f.ContactId == id);
                if(dataContactJson != null)
                {
                    dataContactJson.ContactId = this._ContactsList.Count;
                    dataContactJson.DateTime = DateTime.Now;
                    dataContactJson.Email = email;
                    dataContactJson.FullName = fullName;
                    dataContactJson.PhoneNumber = phoneNumber;
                    dataContactJson.Address = address;
                }
            }
            SaveDataJSON();
            ReadDataJSON();
            return dataContactJson;
        }

        public ContactDataModel GetContactById(int id)
        {
            return this._ContactsList.FirstOrDefault(f => f.ContactId == id);
        }

        public List<ContactDataModel> GetContacts(string fullName, string phoneNumber, string email, string address)
        {
            return _ContactsList.Where(w => (fullName == null || w.FullName.StartsWith(fullName)) &&
                (phoneNumber == null || w.PhoneNumber == phoneNumber) &&
                (email == null || w.Email == email) &&
                (address == null || w.Address == address)
                ).ToList();
        }

        public void RemoveContact(int contactId)
        {
            this._ContactsList.Remove(GetContactById(contactId));
            SaveDataJSON();
            ReadDataJSON();
        }
    }
}