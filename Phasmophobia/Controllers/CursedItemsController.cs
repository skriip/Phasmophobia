using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Phasmophobia.Controllers
{
    public class CursedItemsController : Controller
    {
        // GET: CursedItemsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CursedItemsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CursedItemsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CursedItemsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CursedItemsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CursedItemsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CursedItemsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CursedItemsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
