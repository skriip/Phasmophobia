﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Phasmophobia.Controllers
{
    public class MapController : Controller
    {
        // GET: MapController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MapController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MapController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MapController/Create
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

        // GET: MapController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MapController/Edit/5
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

        // GET: MapController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MapController/Delete/5
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
