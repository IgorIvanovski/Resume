using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Dynamic;
using Resume.Models;

namespace Resume.Controllers
{
    public class AbilityController : Controller
    {
        // GET: Ability
        public ActionResult Index()
        {
            dynamic dynamic = new ExpandoObject();
            dynamic.skillList = GetSkills();
            dynamic.languageList = GetLanguages();
            dynamic.toolList = GetTools();

            return View(dynamic);
        }

        public List<Skill> GetSkills()
        {
            MyResumeEntities myResume = new MyResumeEntities();
            List<Skill> skills = myResume.Skills.ToList();

            return skills;
        }

        public List<Language> GetLanguages()
        {
            MyResumeEntities myResume = new MyResumeEntities();
            List<Language> language = myResume.Languages.ToList();

            return language;
        }

        public List<Tool> GetTools()
        {
            MyResumeEntities myResume = new MyResumeEntities();
            List<Tool> tools = myResume.Tools.ToList();

            return tools;
        }

        //public ActionResult GetPdf(string filename)
        //{
        //    return File(filename, "application/pdf", Server.UrlEncode(filename));
        //}
    }
}