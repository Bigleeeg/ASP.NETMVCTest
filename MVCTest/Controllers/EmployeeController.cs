using MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class EmployeeController : Controller
    {

        public ActionResult AddNew()
        {
            return View();
        }

        public ActionResult SaveEmployee(EmployeeModel model,string BtnSubmit)
        {
            //string BtnSubmit = Request.Form["BtnSubmit"] == null ? "" : Request.Form["BtnSubmit"];

            switch (BtnSubmit)
            {
                case "Save":
                    if (TempData["allData"] == null)
                    {
                        List<EmployeeModel> emList = new List<EmployeeModel> { model };
                        TempData["allData"] = emList;
                    }
                    else
                    {
                        List<EmployeeModel> emList = (List<EmployeeModel>)TempData["allData"];
                        emList.Add(model);
                        TempData["allData"] = emList;
                    }

                    return RedirectToAction("EmployeeList", "Index");
                case "Cancel":
                    return View("AddNew");
                default:
                    return View("AddNew");
            }
        }
    }
}