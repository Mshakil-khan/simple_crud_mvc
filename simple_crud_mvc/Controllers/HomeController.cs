

using simple_crud_mvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Entityfrem.Controllers
{
    public class HomeController : Controller
    {
        StudentBaseContext st = new StudentBaseContext();
        // GET: Home
        public ActionResult Index()
        {
            var a = st.Students2.ToList();
            return View(a);
        }


        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Studentdata s)
        {
            st.Students2.Add(s);
            int a = st.SaveChanges();
            if (a > 0)
            {
                ViewBag.Message = "<script>alert('Data Insert Successfully')</script>";
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            var ed = st.Students2.Where(model => model.Id == id).FirstOrDefault();
            return View(ed);
        }
        [HttpPost]
        public ActionResult Edit(Studentdata sd)
        {
            st.Entry(sd).State = EntityState.Modified;
            st.SaveChanges();
            return View();
        }
        public ActionResult Delete(int id)
        {
            var ed = st.Students2.Where(model => model.Id == id).FirstOrDefault();
            return View(ed);
        }
        [HttpPost]
        public ActionResult Delete(Studentdata sd)
        {
            st.Entry(sd).State = EntityState.Deleted;
            st.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var ed = st.Students2.Where(model => model.Id == id).FirstOrDefault();
            return View(ed);
        }

    }
}










