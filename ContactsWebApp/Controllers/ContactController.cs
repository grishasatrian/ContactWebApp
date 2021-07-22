using ContactsWebApp.Bll.Manager;
using ContactsWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsWebApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ContactController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        public IActionResult Edit(int contactId, bool IsSqlSelected=true)
        {
            ContactViewModel model = new ContactViewModel();
            model.IsSqlSelected = IsSqlSelected;
            ContactManager manager = new ContactManager(model.IsSqlSelected);
            model.ContactItem = manager.GetContactById(contactId);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                ContactManager manager = new ContactManager(model.IsSqlSelected);
                var searchResult = manager.AddEditContacts(model.ContactItem.ContactId,
                    model.ContactItem.FullName, model.ContactItem.PhoneNumber,
                    model.ContactItem.Email, model.ContactItem.Address);
                return RedirectToAction("Contacts", "Home", new { IsSqlSelected = model.IsSqlSelected });
            }
            else
            {
                 return View(model);
            }

        }
        [HttpPost]
        public IActionResult Remove(int contactId, HomeViewModel model)
        {
            ContactManager manager = new ContactManager(model.IsSqlSelected);
            manager.RemoveContact(contactId);
            return RedirectToAction("Contacts", "Home", new { IsSqlSelected = model.IsSqlSelected });            
        }
    }
}