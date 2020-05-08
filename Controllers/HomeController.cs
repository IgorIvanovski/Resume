using Resume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resume.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Work()
        {

            return View();
        }
        public ActionResult Abilities()
        {
            //add a model where I can track the skills through sql
            LanguageContext languageContext = new LanguageContext();
            //Language language = languageContext.languages.OrderBy(lan => lan.LanguageName);
            IOrderedQueryable<Language> language = languageContext.languages.OrderByDescending(lan => lan.Stars);
            //Language language = languageContext.languages.OrderBy(l => l.LanguageName);



            return View(language);
        }
    }
}