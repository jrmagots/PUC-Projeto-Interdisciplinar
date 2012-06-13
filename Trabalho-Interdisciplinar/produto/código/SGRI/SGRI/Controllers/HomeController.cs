<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGRI.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Bem Vindo ao Sistema de Gestão de Infra-Estrutura!";

            return View();
        }

        public ActionResult Gerenciar()
        {
            return View();
        }

        public ActionResult Importar()
        {
            return View();
        }

        public ActionResult Ocorrencias()
        {
            return View();
        }

        public ActionResult Relatorios()
        {
            return View();
        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGRI.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Bem Vindo ao Sistema de Gestão de Infra-Estrutura!";

            return View();
        }

        public ActionResult Gerenciar()
        {
            return View();
        }

        public ActionResult Importar()
        {
            return View();
        }

        public ActionResult Ocorrencias()
        {
            return View();
        }

        public ActionResult Relatorios()
        {
            return View();
        }

    }
}
>>>>>>> 738a82f4e06725b886b2019a1a6c4c845a90a75a
