using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GeradorDocumentos.Controllers
{
    public class CnpjController : Controller
    {
        public IActionResult Gerar_Cnpj()
        {
            return View("gerar_cnpj");
        }


        [HttpPost("/cnpj/gerar_cnpj")]
        public IActionResult PostCnpj(bool pontuacao)
        {
            var cnpj = new NhaNhaNha.Geradores.GeradorCNPJ();

            if(pontuacao)
            {
                ViewBag.Cnpj = cnpj.Gera().Formatado;
                return View("gerar_cnpj");
            }
            ViewBag.Cnpj = cnpj.Gera().Formatado.Replace(".", "").Replace("-","").Replace("/","");

            return View("gerar_cnpj");
        }
    }
}