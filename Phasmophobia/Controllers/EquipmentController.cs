﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Phasmophobia.Controllers
{
    public class EquipmentController : Controller
    {
        // GET: EquipmentController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LaserDots()
        {
            return View();
        }
        public ActionResult Emf5()
        {
            return View();
        }
        public ActionResult GhostBook()
        {
            return View();
        }
        public ActionResult SpiritBox()
        {
            return View();
        }
        public ActionResult Termometr()
        {
            return View();
        }
        public ActionResult UvLigth()
        {
            return View();
        }
        // GET: EquipmentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EquipmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EquipmentController/Create
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

        // GET: EquipmentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EquipmentController/Edit/5
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

        // GET: EquipmentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EquipmentController/Delete/5
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
