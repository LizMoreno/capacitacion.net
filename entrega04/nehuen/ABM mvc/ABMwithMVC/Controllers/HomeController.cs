using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABMwithMVC.Controllers
{
    public class HomeController : Controller
    {
        List<SEG_Users> list = new List<SEG_Users>();
        public ActionResult Index()
        {
            Model1 m = new Model1();
            //var item= m.SEG_Users;
            
            //foreach (var user in item)
            //{
            //    list.Add(user);
            //}
            ViewBag.SEG_Users = m.SEG_Users;
            return View();
        }

        public ActionResult Editar(int id)
        {

            Model1 m = new Model1();
            var item = m.SEG_Users.FirstOrDefault(a => a.Id == id);

            ViewBag.Current = item;
            return View();
        }

        [HttpPost]
        public ActionResult Completado(SEG_Users u )
        {
            Model1 m = new Model1();

            var item = m.SEG_Users.FirstOrDefault(a => a.Id == u.Id);

            item.DisplayName = u.DisplayName;
            item.Email = u.Email;
            item.Password = u.Password;
            item.Active = u.Active;

            m.SaveChanges();


            return View();
        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CompletadoAgregar(SEG_Users u)
        {
            Model1 m = new Model1();
            SEG_Users o = m.SEG_Users.Create();
            o.DisplayName = u.DisplayName;
            o.Email = u.Email;
            o.Password = u.Password;
            o.Active = u.Active;
            m.SEG_Users.Add(o);
            m.SaveChanges();
            return View();
        }




        public ActionResult Eliminar(int id)
        {
            Model1 m = new Model1();
            var a= m.SEG_Users.Find(id);
            m.SEG_Users.Remove(a);
            m.SaveChanges();
            return View();
        }
    }
}