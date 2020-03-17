using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ClientesController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Clientes";

            Model1 model = new Model1();
            var items = model.Operaciones;
            List<Operacione> myList2 = new List<Operacione>();
            foreach (var operacione in items)
            {

                myList2.Add(operacione);
            }
            //var employeeList = new[]
            //{
            //    new Empleados() {Legajo = "1111", Nombre = "Jose"},
            //    new Empleados() {Legajo = "2222", Nombre = "Jose2"},
            //    new Empleados() {Legajo = "3333", Nombre = "Jose3"}

            //};

            //List<Empleados> myList = new List<Empleados>();
            //myList.Add(new Empleados() { Legajo = "1111", Nombre = "Jose" });
            //myList.Add(new Empleados() { Legajo = "222", Nombre = "Jose2" });
            //myList.Add(new Empleados() { Legajo = "3333", Nombre = "Jose3" });

            ViewBag.Operaciones = myList2;
            return View();
        }
    }
}
