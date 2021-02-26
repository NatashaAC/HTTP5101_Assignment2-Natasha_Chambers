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
        /// Will check the spelling of an American word
        /// and convert it to the Canadian spelling if its over four letters long
        /// and ends in "or", if not then it will output the original word
        /// </summary>
        /// <param name="word"> a word </param>
        /// <returns> a sentence containing the user's word with the Canadian and American spelling </returns>
        /// <example>
        ///     GET api/J2/AmeriCanadianChecker/color ->
        ///     "American Spelling: color. Canadian Spelling: colour."
        /// </example>
        ///     GET api/J2/AmeriCanadianChecker/for ->
        ///     "American Spelling: for. Canadian Spelling: for."
        /// <example>
        ///     GET api/J2/AmeriCanadianChecker/taylor ->
        ///     "American Spelling: taylor. Canadian Spelling: taylour."
        /// </example>
        /// <example>
        ///     GET api/J2/AmeriCanadianChecker/container ->
        ///     "The Canadian spelling is the same as the American spelling."
        /// </example>
        [HttpGet]
        [Route("api/J2/AmeriCanadianChecker/{word}")]
        public string AmeriCanadianChecker(string word)
        {
            string message = "";

            // Logic to determine whether the word needs to be converted
            if (word.Length < 4 && word.EndsWith("or"))
            {
                message = "American Spelling: " + word + " Canadian Spelling: " + word;

            } else if (word.Length > 4 && word.EndsWith("or"))
            {
                message = "American Spelling: " + word + " Canadian Spelling: " + word.Replace("or", "our");
            } else
            {
                message = "The Canadian spelling is the same as the American spelling.";
            }

            return message;
        }
    }
}
