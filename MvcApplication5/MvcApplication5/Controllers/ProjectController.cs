using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication5.Models;


namespace MvcApplication5.Controllers
{
    public class ProjectController : Controller
    {
        //
        // GET: /Project/

        public ActionResult Index()
        {
            MVCTestEntities db = new MVCTestEntities();

            var listofprojets = db.Projects.ToList();
            
            return View(listofprojets);
        }

        //
        // GET: /Project/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Project/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Project/Create

        [HttpPost]
        public ActionResult Create(Project project)
        {
            try
            {
                MVCTestEntities db = new MVCTestEntities();

                project.CreatedByName = User.Identity.Name;
                project.CreatedOn = DateTime.UtcNow;
                db.Projects.AddObject(project);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Project/Edit/5
 
        public ActionResult Edit(int id)
        {
             MVCTestEntities db = new MVCTestEntities();

            var project = db.Projects.Where(t => t.ProjectId == id).SingleOrDefault();

            if(project != null)
             return View(project);

            return View("NotFound");
        }

        //
        // POST: /Project/Edit/5

        [HttpPost]
        public ActionResult Edit(Project comingproject)
        {
            try
            {
                MVCTestEntities db = new MVCTestEntities();
                var project = db.Projects.Where(t => t.ProjectId == comingproject.ProjectId).SingleOrDefault();

                if (project != null)
                {
                    project.Name = comingproject.Name;
                    project.Description = comingproject.Description;

                    db.SaveChanges();
                }
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Project/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Project/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
