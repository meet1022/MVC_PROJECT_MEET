using MVC_PROJECT_NOV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Using scafolding view for properties in StudentModel.cs will autometically be created.

namespace MVC_PROJECT_NOV.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Message = Convert.ToString(TempData["StudentSuccess"]);
            return View();
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            ViewData["message"] = "Message to student view page";
            ViewBag.BagMsg = "Msg from Viewbag";
            ViewBag.ControllerMsg = TempData["ControllerMsg"];
            TempData.Keep();
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(StudentModel model)
        {
            try
            {
                // TODO: Add insert logic here
                int stdId = model.StudentId;
                TempData["StudentSuccess"] = "Student " + model.FirstName + "Created successfully";
                //string hiddenMessage = Request["HiddenField"];  //getting message from hidden field.
                string hidden = model.HiddenField;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
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
