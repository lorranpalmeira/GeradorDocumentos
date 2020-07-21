using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GeradorDocumentos.Controllers
{
    public class CpfController : Controller
    {
        public IActionResult Gerar_Cpf()
        {
            return View("gerar_cpf");
        }

        [HttpPost("/cpf/gerar_cpf")]
        public IActionResult PostCpf(bool pontuacao)
        {
            var cpf = new NhaNhaNha.Geradores.GeradorCPF();
            if (pontuacao)
            {
                ViewBag.Cpf = cpf.Gera().Formatado;
                return View("gerar_cpf");
            }
            ViewBag.Cpf = cpf.Gera();
            return View("gerar_cpf");
        }


        [HttpPost]
        public IActionResult ValidaCpf(string cpf)
        {

            var result = NhaNhaNha.Extensions.Extensions.CpfValido(cpf);


            ViewBag.CpfEhValido = result;

            return View("gerar_cpf", result);

        }
    }
}