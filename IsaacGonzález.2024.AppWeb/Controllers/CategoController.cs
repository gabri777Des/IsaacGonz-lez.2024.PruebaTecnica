using Microsoft.AspNetCore.Http;
using IsaacGonzález._2024.BL;
using Microsoft.AspNetCore.Mvc;
using IsaacGonzález._2024.EN;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace IsaacGonzález._2024.AppWeb.Controllers
{
    public class CategoController : Controller
    {
        // GET: CategoController
        public async Task<ActionResult> Index()
        {
            var pcat = await CategoBL.GetAll();
            return View(pcat);
        }

        // GET: CategoController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var pcat = await CategoBL.GetById(id);
            return View(pcat);
        }

        // GET: CategoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Catego catego)
        {
            if (ModelState.IsValid)
            {
                var pcat = await CategoBL.Create(catego);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: CategoController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var pcat = await CategoBL.GetById(id);
            return View(pcat);
        }
        

        // POST: CategoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Catego catego)
        {
            try
            {
                var pcat = await CategoBL.Update(catego);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var pcat = await CategoBL.GetById(id);
            return View(pcat);
        }

        // POST: CategoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Catego catego)
        {
            try
            {
                var pcat = await CategoBL.Delete(catego);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
