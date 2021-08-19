using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_Piemonte.Models;
namespace App_Piemonte.Controllers
{
    public class DepartamentoController : Controller
    {
        public IActionResult Index()
        {

            List<Departamento> list = new List<Departamento>
            {
                new Departamento { id = 1, Name = "Vendas" },
                new Departamento { id = 2, Name = "Operacional" },
                new Departamento { id = 3, Name = "Financeiro" },
                new Departamento { id = 4, Name = "Contratos" },
                new Departamento { id = 5, Name = "Especialista" }
            };
            return View(list);
        }
    }
}
