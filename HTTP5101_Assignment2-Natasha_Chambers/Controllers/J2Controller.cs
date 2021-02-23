using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment2_Natasha_Chambers.Controllers
{
    public class J2Controller : ApiController
    {
        /* J2 2002 Problem - AmeriCanadian
         * Objective:
         * Check the spelling of words, if the word is greater than four letters and ends in "or" 
         * then it is the American spelling and gets converted to the Canadian spelling which ends in "our". 
         * Otherwise if the word ends in "or" but is less than 4 letters long the word is not changed.
         */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>

        [HttpGet]
        [Route("api/J2/AmeriCanadianChecker/{word}")]
        public string AmeriCanadianChecker(string word)
        {
            string message = "";

            if(word.Length < 4)
            {
                message = "American spelling " + word;

            } else if (word.Length > 4)
            {
                message = "Canadian Spelling ";
            }

            return message;
        }
    }
}
