using MadeiraDeCedro.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using MadeiraDeCedro.Domain.Entities;

namespace MadeiraDeCedroWeb.Controllers
{
    public class ServicosController : Controller
    {

        private readonly ApplicationDbContext _db;

        public ServicosController( ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var Servicos = _db.Servicos.ToList();
            return View(Servicos);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Servicos obj)
        {
            if (ModelState.IsValid)
            {
                _db.Servicos.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
            public ActionResult Update(int ServicoId)
            {
                Servicos? obj = _db.Servicos.FirstOrDefault(u => u.Id == ServicoId);

                if (obj == null)
                {
                    return RedirectToAction("Error", "Home");
                }
                return View(obj);
            }
            [HttpPost]
            public IActionResult Update(Servicos obj)
            {
                if (ModelState.IsValid)
                {
                    _db.Servicos.Update(obj);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(obj);
            }
    }
}
