using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GeradorDocumentos.Controllers
{
    public class PessoaController : Controller
    {

        public IActionResult Gerar_Pessoa()
        {
            return View("gerar_pessoa");
        }

        
        [HttpPost("/pessoa/gerar_nome")]
        public IActionResult Post()
        {


            var pessoaConf = new NhaNhaNha.Geradores.PessoaConfiguracao();

            var random = new Random().Next(0,2);

            if (random == 0)
                pessoaConf.Sexo = NhaNhaNha.Modelos.Sexo.Mulher;
            //pessoaConf.FaixaEtaria = NhaNhaNha.Modelos.FaixaEtaria.Adulto;

            var pessoaNome = new NhaNhaNha.Geradores.GeradorPessoa().Gera(pessoaConf).PrimeiroNome ?? "Carlos";
            var pessoaSobrenome = new NhaNhaNha.Geradores.GeradorPessoa().Gera(pessoaConf).SobreNome ?? "Nascimento"; 
           

            ViewBag.pessoaNome = pessoaNome;
            ViewBag.pessoaSobrenome = pessoaSobrenome;
            return View("gerar_pessoa");
        }
    }
}