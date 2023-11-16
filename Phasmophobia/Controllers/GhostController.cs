using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Phasmophobia.Controllers
{
    public class GhostController : Controller
    {
        // GET: GhostController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GhostController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GhostController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GhostController/Create
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

        // GET: GhostController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GhostController/Edit/5
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

        // GET: GhostController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GhostController/Delete/5
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
