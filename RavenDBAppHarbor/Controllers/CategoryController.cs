using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RavenDBAppHarbor.Models;

namespace RavenDBAppHarbor.Controllers
{
    public class CategoryController : RavenController
    {
        public ActionResult Index()
        {
            var model = this.RavenSession.Query<Category>().ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            var model = new Category();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            this.RavenSession.Store(category);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(string id)
        {
            var model = this.RavenSession.Load<Category>(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            this.RavenSession.Store(category);
            return RedirectToAction("Index");
        }


        public ViewResult Details(string id)
        {
            var model = this.RavenSession.Load<Category>(id);
            return View(model);
        }

        public ActionResult Delete(string id)
        {
            var model = this.RavenSession.Load<Category>(id);
            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            this.RavenSession.Advanced.DatabaseCommands.Delete(id, null);
            return RedirectToAction("Index");
        }

    }
}