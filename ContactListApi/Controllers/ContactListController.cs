using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ContactListApi.Controllers
{
    public class ContactListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
