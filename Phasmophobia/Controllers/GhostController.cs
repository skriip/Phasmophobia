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
        public ActionResult Demon()
        {
            return View();
        }
        public ActionResult Banshee()
        {
            return View();
        }
        public ActionResult Deogen()
        {
            return View();
        }
        public ActionResult Goryo()
        {
            return View();
        }
        public ActionResult Hantu()
        {
            return View();
        }
        public ActionResult Mare()
        {
            return View();
        }
        public ActionResult Jinn()
        {
            return View();
        }
        public ActionResult Mimic()
        {
            return View();
        }
        public ActionResult Moroi()
        {
            return View();
        }
        public ActionResult Myling()
        {
            return View();
        }
        public ActionResult Obake()
        {
            return View();
        }
        public ActionResult Oni()
        {
            return View();
        }
        public ActionResult Onryo()
        {
            return View();
        }
        public ActionResult Phantom()
        {
            return View();
        }
        public ActionResult Poltergeist()
        {
            return View();
        }
        public ActionResult Raiju()
        {
            return View();
        }
        public ActionResult Revenant()
        {
            return View();
        }
        public ActionResult Shade()
        {
            return View();
        }
        public ActionResult Spirit()
        {
            return View();
        }
        public ActionResult Thaye()
        {
            return View();
        }
        public ActionResult Twins()
        {
            return View();
        }
        public ActionResult Wraith()
        {
            return View();
        }
        public ActionResult Yokai()
        {
            return View();
        }
        public ActionResult Yurei()
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
