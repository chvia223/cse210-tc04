using System;

namespace cse210_tc04
{
    class Dealer
    {
        //int _numDeals = 0;
        public int _previousCard = 0;
        public int _newCard = 0;

        string _guess = "empty";

        // public bool IsFirstCard()
        // {
        //     return _numDeals == 0;
        // }

        
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

        public string UserGuess()
        {
            Console.Write($"Higher or lower? [h/l] ");
            string userGuess = Console.ReadLine();
            _guess = userGuess;
            return userGuess;
        }
    }
}
