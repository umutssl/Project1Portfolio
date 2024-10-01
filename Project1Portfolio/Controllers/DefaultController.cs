using Project1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1Portfolio.Controllers
{
    public class DefaultController : Controller
    {
        MypotfoiloDbEntities context= new MypotfoiloDbEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();   
        }
        public PartialViewResult PartialHeader()
        {
            ViewBag.titel=context.About.Select(x=>x.Titel).FirstOrDefault();
            ViewBag.detail=context.About.Select(x=>x.Detail).FirstOrDefault();
            ViewBag.imageUrl=context.About.Select(x=>x.İmageUrl).FirstOrDefault(); 
            ViewBag.addres=context.Profile.Select(x=>x.Address).FirstOrDefault();
            ViewBag.email=context.Profile.Select(x=>x.Email).FirstOrDefault();
            ViewBag.phone=context.Profile.Select(x=>x.Phonenumber).FirstOrDefault();
            ViewBag.github=context.Profile.Select(x=>x.Github).FirstOrDefault();
            return PartialView();   
        }

        public PartialViewResult PartialAbout()
        {
            ViewBag.titel = context.Profile.Select(x => x.Titel).FirstOrDefault();
            ViewBag.description = context.Profile.Select(x => x.Description).FirstOrDefault();
            ViewBag.phone = context.Profile.Select(x => x.Phonenumber).FirstOrDefault();
            ViewBag.email = context.Profile.Select(x => x.Email).FirstOrDefault();
            ViewBag.ımageUrl = context.Profile.Select(x => x.ImageUrl).FirstOrDefault();

            return PartialView();   
        }
        public PartialViewResult ParrtialEducation()
        {
            var values=context.Education.ToList();
            return PartialView(values);
        }
       
        
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}