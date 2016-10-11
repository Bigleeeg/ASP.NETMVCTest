using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTest.Models;

namespace MVCTest.Controllers
{
    public class IndexController : Controller
    {
        public ActionResult EmployeeList()
        {
            List<EmployeeModel> emList = new List<EmployeeModel>();

            if (TempData["allData"] != null)
            {
                emList = (List<EmployeeModel>)TempData["allData"];
            }
            else
            {
                emList.Add(new EmployeeModel { Name = "张三", Info = "developer", Salary = 10000 });
                emList.Add(new EmployeeModel { Name = "李四", Info = "manager", Salary = 20000 }); 
            }
            TempData["allData"] = emList;

            List<EmployeeViewModel> evmList = new List<EmployeeViewModel>();
            if (emList != null && emList.Count > 0)
            {
                foreach (var item in emList)
                {
                    EmployeeViewModel evm = new EmployeeViewModel();
                    evm.EmployeeName = item.Name;
                    evm.EmployeeInfo = item.Info;
                    evm.Salary = item.Salary;
                    if (item.Salary >= 20000)
                    {
                        evm.SalaryColor = "red";
                    }
                    else
                    {
                        evm.SalaryColor = "yellow";
                    }
                    evmList.Add(evm);
                }
            }
            ViewData["employeeModel"] = evmList;
            return View();
        }
    }
}