using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC;

namespace WebApplicationMVC.Controllers
{
    public class SEG_UsersController : Controller
    {
        private Model1 db = new Model1();

        // GET: SEG_Users
        public ActionResult Index()
        {
            Model1 model = new Model1();
            var items = model.SEG_Users;
            List<SEG_Users> lista = new List<SEG_Users>();
            foreach (var elemento in items)
            {
                lista.Add(elemento);
            }

            ViewBag.SEG_Users = lista;
            return View();
            //return View(db.SEG_Users.ToList());
        }

        // GET: SEG_Users/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SEG_Users sEG_Users = db.SEG_Users.Find(id);
            if (sEG_Users == null)
            {
                return HttpNotFound();
            }
            return View(sEG_Users);
        }

        // GET: SEG_Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SEG_Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DisplayName,Email,Password,Active")] SEG_Users sEG_Users)
        {
            if (ModelState.IsValid)
            {
                db.SEG_Users.Add(sEG_Users);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sEG_Users);
        }

        // GET: SEG_Users/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SEG_Users sEG_Users = db.SEG_Users.Find(id);
            if (sEG_Users == null)
            {
                return HttpNotFound();
            }
            return View(sEG_Users);
        }

        // POST: SEG_Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DisplayName,Email,Password,Active")] SEG_Users sEG_Users)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sEG_Users).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sEG_Users);
        }

        // GET: SEG_Users/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SEG_Users sEG_Users = db.SEG_Users.Find(id);
            if (sEG_Users == null)
            {
                return HttpNotFound();
            }
            return View(sEG_Users);
        }

        // POST: SEG_Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            SEG_Users sEG_Users = db.SEG_Users.Find(id);
            db.SEG_Users.Remove(sEG_Users);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
