using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    public class ValuesController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get()
        {
            List<Empleados> myList = new List<Empleados>();
            myList.Add(new Empleados() { Legajo = "1111", Nombre = "Jose" });
            myList.Add(new Empleados() { Legajo = "222", Nombre = "Jose2" });
            myList.Add(new Empleados() { Legajo = "3333", Nombre = "Jose3" });

            return Json(myList);
        }


         
 


        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
