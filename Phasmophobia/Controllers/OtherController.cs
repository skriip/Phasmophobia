using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Phasmophobia.Controllers
{
    public class OtherController : Controller
    {
        // GET: OtherController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OtherController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OtherController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OtherController/Create
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

        // GET: OtherController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OtherController/Edit/5
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

        // GET: OtherController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OtherController/Delete/5
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
        public ActionResult Van()
        {
            return View();
        }
        public ActionResult Prestige()
        {
            return View();
        }
        public ActionResult Challenge()
        {
            return View();
        }
        public ActionResult Difficulties()
        {
            return View();
        }

    }
}
