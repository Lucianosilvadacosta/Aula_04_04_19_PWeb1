using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VIEWS_TIPADAS.Models;

namespace VIEWS_TIPADAS.Controllers
{
    public class FuncaoController : Controller
    {
        // GET: Funcao
        public ActionResult Lista()
        {

            List<FUNCAO> nomeDaLista = new List<FUNCAO>();

            nomeDaLista.Add(new FUNCAO() { FuncaoId = 1, NomeFuncao = "Dev", Salario = 700 });
            nomeDaLista.Add(new FUNCAO() { FuncaoId = 2, NomeFuncao = "Analista", Salario = 900000000 });

            return View();


            /*
            FUNCAO f1 = new FUNCAO();
            f1.FuncaoId = 1;
            f1.NomeFuncao = "Desenvolvedor";
            f1.Salario = 700;

            FUNCAO f2 = new FUNCAO();
            f2.FuncaoId =2;
            f2.NomeFuncao = "Analista";
            f2.Salario = 900;



            nomeDaLista.Add(f1);
            nomeDaLista.Add(f2); */




            return View();
        }
    }
}