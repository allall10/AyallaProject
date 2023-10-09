using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace projectAyallaEfratNoa.Controllers
{
    public class workController : Controller
    {
        // GET: woekController
        public ActionResult Index()
        {
            return View();
        }

        // GET: woekController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: woekController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: woekController/Create
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

        // GET: woekController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: woekController/Edit/5
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

        // GET: woekController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: woekController/Delete/5
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
