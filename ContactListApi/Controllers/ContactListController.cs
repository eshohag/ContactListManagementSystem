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
    }
}
