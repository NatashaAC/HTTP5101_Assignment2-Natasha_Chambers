using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment2_Natasha_Chambers.Controllers
{
    public class J3Controller : ApiController
    {
        /* J3/S1 2001 Problem - Keeping Score
         * Objective:
         * Award points to a player based on the 13 cards they have in their hand. 
         * If they have an ace, king, queen, or jack then the player will receive points, 
         * the player will also recieve points if they have a void, singleton or doubleton.
        */

        /// <summary>
        /// Award points to a player based on the 13 cards they have in their hand. 
        /// If they have an ace, king, queen, or jack then the player will receive points,
        /// the player will also recieve points if they have a void, singleton or doubleton.
        /// </summary>
        /// <param name="cards"> a string representing a player's hand </param>
        /// <returns> cards in players hand sorted by suit, points awarded by each suit, and the total amount of points </returns>
        /// <example>
        ///     GET api/J3/KeepScore/C258TJKD69QAHSTJA ->
        ///     Clubs 2 5 8 T J K    Points 4
        ///     Diamonds 6 9 Q A     Points 6
        ///     Hearts               Points 3
        ///     Spades T J A         Points 5
        ///                          Total  18
        /// </example>
        /// <example>
        ///     GET api/J3/KeepScore/CAD578KAHAS47TQKA ->
        ///     Clubs A                Points 6
        ///     Diamonds 5 7 8 K A     Points 7
        ///     Hearts A               Points 6
        ///     Spades 4 7 T Q K A     Points 9
        ///                            Total  28
        /// </example>

        [HttpGet]
        [Route("api/J3/KeepScore/{cards}")]
        public string KeepScore(string cards)
        {
            // Variables for points basedd on certain card values
            int ace = 4;
            int king = 3;
            int queen = 2;
            int jack = 1;

            // Variables for points based on the number of suits in a player's hand
            int voidSuit = 3;
            int singletonSuit = 2;
            int doubletonSuit = 1;

            // Variables for suit characters
            string clubs = "C";
            string diamonds = "D";
            string hearts = "H";
            string spades = "S";

            // Variable for the total amount of points for the player
            int totalPoints = 0;

            // Looping through the string
            for(int i = 0; i < cards.Length; i++)
            {
                /* // Checking for the type of suit to focus on
                 Where string contains character C OR D OR H OR S
                 {
                     COUNT the number of cards in the suit
                     {
                         IF the number of cards are EQUAl to OR LESS THAN 3
                         {
                            UPDATE the player's points based on the void, singleton and doubleton variables
                         }
                         IF any of the charatcers in the suit match ace, king, queen or jack
                         {
                            UPDATE the player's points
                         }
                     }
                 } */
            }

            // RETURN the user's cards SORTED by suit with the amount of points each suit adds 
            // to the player's total AND the total number of points the player got

            return cards;
        }
    }
}
