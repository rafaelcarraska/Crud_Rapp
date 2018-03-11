using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Handson.Models;
using Handson.Business;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace Handson.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ArmasBusiness _ArmasBusiness = new ArmasBusiness();
            LocaisBusiness _LocaisBusiness = new LocaisBusiness();
            SuspeitosBusiness _SuspeitosBusiness = new SuspeitosBusiness();

            //Carrega as listas de Armas, locais e Suspeitos
            List<Armas> list_armas = _ArmasBusiness.Listar_Armas();
            List<Locais> list_locais = _LocaisBusiness.Listar_Locais();
            List<Suspeitos> list_suspeitos = _SuspeitosBusiness.Listar_Suspeitos();

            //View dos ComboBox 
            ViewBag.Armas = list_armas;
            ViewBag.Locais = list_locais;
            ViewBag.Suspeitos = list_suspeitos;

            //Salva um 'CRIME' aleatorio
            Startup.Caso = Tuple.Create(list_suspeitos.OrderBy(x => Guid.NewGuid()).First(),
                                        list_armas.OrderBy(x => Guid.NewGuid()).First(),
                                        list_locais.OrderBy(x => Guid.NewGuid()).First());

            return View();
        }

        public string Caso(int suspeito, int arma, int local)
        {
            //Verificar as possiveis soluções
            List<int> erros = new List<int>();
            if (Startup.Caso.Item1.ID != suspeito)
            {
                erros.Add(1);
            }
            if (Startup.Caso.Item2.ID != arma)
            {
                erros.Add(3);
            }
            if (Startup.Caso.Item3.ID != local)
            {
                erros.Add(2);
            }
            if (erros.Count == 0)
            {
                erros.Add(0);
            }
            //returna o Json com um resultado aleatorio
            return JsonConvert.SerializeObject(erros.OrderBy(x => Guid.NewGuid()).First()); ;
        }
    }
}