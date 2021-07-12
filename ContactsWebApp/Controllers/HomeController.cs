using ContactsWebApp.Bll.Manager;
using ContactsWebApp.Dal;
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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Search all contacts
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="IsSqlSelected"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Contacts(int contactId, bool IsSqlSelected = true)
        {
            HomeViewModel model = new HomeViewModel();
            model.IsSqlSelected = IsSqlSelected;
            ContactManager manager = new ContactManager(model.IsSqlSelected);
            if(contactId > 0)
            {
                var item = manager.GetContactById(contactId);
                if(item!=null)
                {
                    model.Id = item.ContactId;
                    model.Address = item.Address;
                    model.FullName = item.FullName;
                    model.PhoneNumber = item.PhoneNumber;
                    model.Email = item.Email;
                    model.DateTime = item.DateTime;
                }
            }
            model.SearchResult = manager.GetContacts(null, null, null, null);
            return View(model);
            
        }

        [HttpPost]
        public IActionResult Contacts(HomeViewModel model)
        {
            ModelState.Clear();
            var manager = new ContactManager(model.IsSqlSelected);
            model.SearchResult = manager.GetContacts(model.FullName, model.PhoneNumber, model.Email, model.Address);
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(HomeViewModel model)
        {
            if (ModelState.IsValid)
            {
                ContactManager manager = new ContactManager(model.IsSqlSelected);
                var searchResult = manager.AddEditContacts(model.Id,
                    model.FullName, model.PhoneNumber,
                    model.Email, model.Address);

                return RedirectToAction("Contacts", "Home", new { IsSqlSelected= model.IsSqlSelected });
            }
            else
            {
                ContactManager manager = new ContactManager(model.IsSqlSelected);
                model.SearchResult = manager.GetContacts(null, null, null, null);
                return View("Contacts", model);
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
