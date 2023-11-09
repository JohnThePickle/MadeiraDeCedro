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

    }
}
