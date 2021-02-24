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
        /* J1 2008 Problem - Body Mass Index 
         * Objective:
         * Calculate the BMI of a patient based on their height in metres and weight in kilograms. 
         * Then displays a message telling the patient that they are overweight, 
         * normal weight or underweight. 
        */

        /// <summary>
        ///     Returns health condition of a patient which is overweight, normal weight, or 
        ///     underweight based on their BMI calculated by their input of weight in kilograms
        ///     and height in metres
        /// </summary>
        /// <param name="weight"> decimal value of a patient's weight </param>
        /// <param name="height"> decimal value of a patient's height </param>
        /// <returns> A sentence describing the BMI of a patient </returns>
        /// <example> 
        ///     GET api/J1/BMICalculator/69/1.73/ -> 
        ///     "The patient's BMI is . According to the table, the patient is Normal weight"
        /// </example>
        /// <example> 
        ///     GET api/J1/BMICalculator/84.5/1.8/ -> 
        ///     "The patient's BMI is . According to the table, the patient is Overweight"
        /// </example>
        /// <example> 
        ///     GET api/J1/BMICalculator/45/1.65/ -> Underweight 
        ///     "The patient's BMI is . According to the table, the patient is Underweight"
        /// </example>
        /// <example> 
        ///     GET api/J1/BMICalculator/-78/1.40/ -> "Unable to calculate BMI"
        /// </example>
        [HttpGet]
        [Route("api/J1/BMICalculator/{weight}/{height}/")]
        public string BMICalculator(decimal weight, decimal height)
        {
            // BMI formula
            decimal bmi = weight / (height * height);

            string category = "";

            // Logic to deal with negative input for height and weight
            if (weight < 0 || height < 0)
            {
                return "Unable to calculate BMI";
            } else
            {
                // Logic to determine what category the patient is in
                if (bmi > 25)
                {
                    category = "Overweight";
                }
                else if (bmi > 18  && bmi < 25)
                {
                    category = "Normal weight";
                }
                else if (bmi < 18)
                {
                    category = "Underweight";
                }
            }

            // Message that stores the bmi calculation and category
            string message = "The patient's BMI is " + Math.Round(bmi, 2) + ". According to the table, the patient is " + category;

            return message;
        }
    }
}
