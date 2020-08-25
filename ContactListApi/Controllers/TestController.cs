using ContactListApi.Models;
using ContactListApi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ContactListApi.Controllers
{
    public class TestController : Controller
    {
        private readonly ContactListContext _context;

        public TestController(ContactListContext context)
        {
            _context = context;
        }

        // GET: Test
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactListItems.ToListAsync());
        }

        // GET: Test/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactListItem = await _context.ContactListItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactListItem == null)
            {
                return NotFound();
            }

            return View(contactListItem);
        }

        // GET: Test/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Test/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ContactListItem contactListItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactListItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactListItem);
        }

        // GET: Test/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactListItem = await _context.ContactListItems.FindAsync(id);
            if (contactListItem == null)
            {
                return NotFound();
            }
            return View(contactListItem);
        }

        // POST: Test/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,FirstName,LastName,Phone,Email,JobTitle,Company,City,Country")] ContactListItem contactListItem)
        {
            if (id != contactListItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactListItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactListItemExists(contactListItem.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(contactListItem);
        }

        // GET: Test/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactListItem = await _context.ContactListItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactListItem == null)
            {
                return NotFound();
            }

            return View(contactListItem);
        }

        // POST: Test/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var contactListItem = await _context.ContactListItems.FindAsync(id);
            _context.ContactListItems.Remove(contactListItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactListItemExists(long id)
        {
            return _context.ContactListItems.Any(e => e.Id == id);
        }
    }
}
