using IsaacGonzález._2024.BL;
using IsaacGonzález._2024.EN;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IsaacGonzález._2024.AppWeb.Controllers
{
    public class ProducController : Controller
    {
        // GET: ProducController
        public async Task<ActionResult> IndexAsync()
        {
            var pcat = await ProducBL.GetAll();
            return View(pcat);
        }

        // GET: ProducController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var pcat = await ProducBL.GetById(id);
            return View(pcat);
        }

        // GET: ProducController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProducController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Produc produc)
        {
            if (ModelState.IsValid)
            {
                var pcat = await ProducBL.Create(produc);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: ProducController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var pcat = await ProducBL.GetById(id);
            return View(pcat);
        }

        // POST: ProducController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Produc catego)
        {
            try
            {
                var pcat = await ProducBL.Update(catego);
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProducController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var pcat = await ProducBL.GetById(id);
            return View(pcat);
        }

        // POST: ProducController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Produc produc)
        {
            try
            {
                var pcat = await ProducBL.Delete(produc);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
