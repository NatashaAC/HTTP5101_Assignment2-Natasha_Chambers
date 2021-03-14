using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTTP5101_Assignment2_Natasha_Chambers.Models;

namespace HTTP5101_Assignment2_Natasha_Chambers.Controllers
{
    public class BMIController : Controller
    {
        // GET: BMI
        public ActionResult Index()
        {
            return View();
        }

        // POST /BMI/Show
        // Aquire information about BMI calculation and send it to the Show.cshtml
        [HttpPost]
        public ActionResult Show(decimal weight, decimal height)
        {

            // Determine BMI based on the information provided
            BMIApiController controller = new BMIApiController();
            BMI PatientInfo = controller.BMICalculator(weight, height);

            return View(PatientInfo);
        }
    }
}