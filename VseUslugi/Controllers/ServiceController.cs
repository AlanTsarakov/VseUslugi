using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VseUslugi.Data;

namespace VseUslugi.Controllers
{
    public class ServiceController : Controller
    {


        IAppealRepository appealRepository;

        public ServiceController(IAppealRepository productRepository)
        {
            this.appealRepository = productRepository;
        }


        // GET: ServiceController
        public ActionResult Index()
        {
            var allAppeals = appealRepository.GetAll();
            return View(allAppeals);
        }

        // GET: ServiceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ServiceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServiceController/Create
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


        // GET: ServiceController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var appeal = appealRepository.TryGetById(id);
            return View(appeal);
        }

        // POST: ServiceController/Edit/5
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

        // GET: ServiceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ServiceController/Delete/5
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
