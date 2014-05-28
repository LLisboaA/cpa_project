using System;
using System.Web.Mvc;
using CPA_Project.Areas.Admin.Models;

namespace CPA_Project.Areas.Admin.Controllers
{
    public class AvaliacaoController : Controller
    {
        //
        // GET: /Admin/Avaliacao/
        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(AvaliacaoViewModel avaliacao)
        {
            return View();
        }
	}

    public class AvaliacaoViewModel
    {
        public string Nome { get; set; }

        public DateTime Data_criacao { get; set; }

        public DateTime Data_expedicao { get; set; }
        public int Questao_id { get; set; }
    }
}