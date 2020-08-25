using ContactListApi.Models;
using ContactListApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ContactListApi.Controllers
{
    public class ContactListController : Controller
    {
        private readonly IContactListItemRepository _contactListItemRepository;

        public ContactListController(IContactListItemRepository contactListItemRepository)
        {
            _contactListItemRepository = contactListItemRepository;
        }
        public IActionResult Index()
        {
            var list = _contactListItemRepository.All().ToList();
            return View(list);
        }
        public IActionResult Create()
        {
            return View(new ContactListItem());
        }
        [HttpPost]
        public IActionResult Create(ContactListItem model)
        {
            return View(new ContactListItem());
        }
        public IActionResult Edit(int id=0)
        {
            return View(new ContactListItem());
        }
        [HttpPost]
        public IActionResult Edit(ContactListItem model)
        {
            return View(new ContactListItem());
        }
        public IActionResult Delete(int id = 0)
        {
            return View(new ContactListItem());
        }
        [HttpPost]
        public IActionResult Delete(ContactListItem model)
        {
            return View(new ContactListItem());
        }
    }
}
