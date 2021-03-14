using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HTTP5101_Assignment2_Natasha_Chambers.Models;

namespace HTTP5101_Assignment2_Natasha_Chambers.Controllers
{
    public class BMIApiController : ApiController
    {
        /* J1 2008 Problem - Body Mass Index 
         * Objective:
         * Calculate the BMI of a patient based on their height in metres and weight in kilograms. 
         * Then display a message telling the patient that they are overweight, normal weight or underweight. 
        */

        /// <summary>
        /// Calculates a patient's BMI based on their weight (kilograms) and their height (meters).
        /// Then returns a message with their BMI and weight category (overweight, normal weight, underweight)
        /// </summary>
        /// <param name="weight"> decimal value of a patient's weight </param>
        /// <param name="height"> decimal value of a patient's height </param>
        /// <returns> A sentence describing the BMI of a patient </returns>
        /// <example> 
        ///     GET api/BMIApi/BMICalculator/69/1.73/ -> 
        ///     "The patient's BMI is 23.05. According to the table, the patient is Normal weight"
        /// </example>
        /// <example> 
        ///     GET api/BMIApi/BMICalculator/84.5/1.8/ -> 
        ///     "The patient's BMI is 26.08. According to the table, the patient is Overweight"
        /// </example>
        /// <example> 
        ///     GET api/BMIApi/BMICalculator/45/1.65/ -> 
        ///     "The patient's BMI is 16.53. According to the table, the patient is Underweight"
        /// </example>
        /// <example> 
        ///     GET api/BMIApi/BMICalculator/-78/1.40/ -> "Unable to calculate BMI"
        /// </example>
        [HttpGet]
        [Route("api/BMIApi/BMICalculator/{weight}/{height}/")]
        public BMI BMICalculator(decimal weight, decimal height)
        {
            // BMI formula
            decimal bmi = weight / (height * height);

            string category = "";

            // Logic to deal with negative input for height and weight
            if (weight <= 0 || height <= 0)
            {
                category = "Unable to calculate BMI";
            } else
            {
                // Logic to determine what category the patient is in 
                if (bmi >= 25)
                {
                    category = "Overweight";
                }
                else if (bmi > 18  && bmi < 25)
                {
                    category = "Normal weight";
                }
                else if (bmi <= 18)
                {
                    category = "Underweight";
                } else
                {
                    category = "Unable to calculate BMI";
                }
            }

            BMI PatientInfo = new BMI();
            PatientInfo.PatientBMI = Math.Round(bmi, 2);
            PatientInfo.PatientCategory = category;

            return PatientInfo;
        }
    }
}
