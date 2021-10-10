using System;

namespace cse210_tc04
{
    /// <summary>
    /// Represents the dealer; draw new cards, keep trak of the previous card 
    /// and compare with the new card. Record the guess of the user and compares it
    /// with reality.
    /// <summary>
    class Dealer
    {
        // Declaring the member variables here
        public int _previousCard = 0;
        public int _newCard = 0;
        string _guess = "empty";

        /// <summary>
        /// in a new draw, changes position of the card in the variable.
        /// If the player choose to play again, swithcs the card already visible to the
        /// place that will be compared to the new card
        /// </summary> 
        public int ChangeCardPlaces()
        {
            _previousCard = _newCard;
            return _previousCard;
        }
        ///<summery>
        /// This generates a number from 1-13 
        /// 
        /// this returns the number that was picked.
        ///</summary> 
        public int DrawCard()
        {

            int number = 0;
            Random randomGenerator = new Random();

            for (int i = 0; i < 2; i++)
            {
                number = randomGenerator.Next(1,13);
            }
            
            _newCard = number;
            return number;
        }

        // Determines whether the new card is high or lower than the previous card and returns h or l
        // This will be used in the points function to against user input
        public string HigherOrLower()
        {
            string newCard = "l";
            if (_previousCard < _newCard)
            {
                newCard = "h";
            }

            return newCard;
        }

         // Add points or removes points based on the user input
        // Checkes with HigherOrLower function to determine if points should be added/removed from score
        // returns added points to be added/removed from the score
        public int Points()
        {
            int addingPoints = -75;

            if (_guess == HigherOrLower())
            {
                addingPoints = 100;
            }

            return addingPoints;
        }

        /// <summary>
        /// Will display a high or low prompt and
        /// read the user's input.
        /// </summary>
        /// <returns>The letter selected by the user</returns>
        public string UserGuess()
        {
            Console.Write($"Higher or lower? [h/l] ");
            string userGuess = Console.ReadLine();
            _guess = userGuess;
            return userGuess;
        }
    }
}
