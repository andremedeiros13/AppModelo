using Dev.UI.Site.Data;
using Dev.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dev.UI.Site.Controllers
{
    public class CrudController1 : Controller
    {
        private readonly MeuDbContext _contexto;

        public CrudController1(MeuDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Andre",
                DataNascimento = DateTime.Now,
                Email = "andre@andre.com.br"
            };

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            var aluno2 = _contexto.Alunos.Find(aluno.Id);
            var aluno3 = _contexto.Alunos.FirstOrDefault(a => a.Email == "andre@andre.com.br");
            var aluno4 = _contexto.Alunos.Where(a => a.Nome == "Andre");

            aluno.Nome = "João";
            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();

            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();

            return View("_Layout");
        }
    }
}
