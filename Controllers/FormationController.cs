using ExerciceAspnetMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExerciceAspnetMvc.Controllers
{
    public class FormationController : Controller
    {
        // GET: Formation
        public ActionResult DetailFormation(string categorie,string nomSeo)
        {
            var vm = new FormationViewModel();
            vm.Categorie = categorie;
            vm.NomSeo = nomSeo;
            return View(vm);
        }
        public ActionResult FormationParCatégorie(string categorie)
        {

            return View();
        }

        public ActionResult ToutesLesFormations()
        {
            return View();
        }


    }
}