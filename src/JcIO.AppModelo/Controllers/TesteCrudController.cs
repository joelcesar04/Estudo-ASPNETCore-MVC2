using JcIO.Site.Data;
using JcIO.Site.Models;
using Microsoft.AspNetCore.Mvc;

namespace JcIO.Site.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _context;
        public TesteCrudController(MeuDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var aluno = new Aluno()
            {
                Nome = "Joel",
                DataNascimento = DateTime.Now,
                Email = "joel@email.com"
            };

            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            var aluno2 = _context.Alunos.Find(aluno.Id);
            var aluno3 = _context.Alunos.FirstOrDefault(a => a.Email == "joel@email.com");
            var aluno4 = _context.Alunos.Where(a => a.Nome == "Joel");
            aluno.Nome = "João";

            _context.Alunos.Update(aluno);
            _context.SaveChanges();

            _context.Alunos.Remove(aluno);
            _context.SaveChanges();

            return View();
        }
    }
}
