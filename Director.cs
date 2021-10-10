using System;

namespace cse210_tc04
{
    ///<summary> this class is responsible for the game. It keeps track for the score,
    /// the interactions between functions and when they should be called.
    /// It also coordinate if the player wants to keep playing.
    /// <summary>
    class Director
    {
        int _score = 300;
        bool _playAgain = true;
        
        Dealer _dealer = new Dealer();

        ///<summary>
        /// Will start a new instance of the game. 
        /// <summary>
        public void StartGame()
        {
            _dealer.DrawCard();
            while (_score > 0 && _playAgain)
            {
                Console.WriteLine($"The card is: {_dealer._newCard}");
                _dealer.ChangeCardPlaces();
                _dealer.UserGuess();
                _dealer.DrawCard();
                _dealer.HigherOrLower(); 
                Console.WriteLine($"Next card was: {_dealer._newCard}");
                _score = _score + _dealer.Points();
                Console.WriteLine($"Your score is: {_score}");
                if (_score <= 0)
                {
                    break;
                }
                Console.Write($"Keep playing? [y/n] ");
                string wantToPlay = Console.ReadLine();
                _playAgain = (wantToPlay == "y");
                Console.WriteLine("");
            }

            Console.WriteLine($"Thanks for playing");
        }
    } // end of class: Director
}