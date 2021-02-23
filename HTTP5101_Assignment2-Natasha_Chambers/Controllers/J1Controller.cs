using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment2_Natasha_Chambers.Controllers
{
    public class J1Controller : ApiController
    {
        /* J1 2008 Problem: Body Mass Index 
         * Objective:
         * Calculate the BMI of a patient based on their height in metres and weight in kilograms. 
         * Then displays a message telling the patient that they are overweight, 
         * normal weight or underweight. 
        */

        /// <summary>
        /// Returns health condition of a patient which is overweight, normal weight, or 
        /// underweight based on their BMI calculated by their input of  weight in kilograms
        /// and height in metres
        /// </summary>
        /// <param name="weight">decimal value of the patient's weight</param>
        /// <param name="height">decimal value of the patient's height</param>
        /// <returns> a word related to the BMI of a patient </returns>
        /// <example> GET api/J1/BMICalculator/69/1.73 -> Normal weight </example>
        /// <example> GET api/J1/BMICalculator/84.5/1.8 -> Overweight </example>
        /// <example> GET api/J1/BMICalculator/45/1.65 -> Underweight </example>
        /// <example> GEt api/J1/BMICalculator/-78/1.40 -> Unable to calculate BMI </example>

        [HttpGet]
        [Route("api/J1/BMICalculator/{weight}/{height}")]
        public string BMICalculator(decimal weight, decimal height)
        {
            decimal bmi = weight / (height * height);

            string message = "";

            if (bmi > 25)
            {
                message = "Overweight";
            }
            else if (bmi > 18 && bmi < 25)
            {
                message = "Normal weight";
            }
            else if (bmi < 18)
            {
                message = "Underweight";
            }

            return message;
        }
    }
}
