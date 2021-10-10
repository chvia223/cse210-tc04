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

        public string HigherOrLower()
        {
            string newCard = "l";
            if (_previousCard < _newCard)
            {
                newCard = "h";
            }

            return newCard;
        }

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
