using System;

namespace cse210_tc04
{
    class Director
    {
        int _score = 300;

        bool _playAgain = true;
        
        Dealer _dealer = new Dealer();

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

        void GetInputs()
        {
            throw new NotImplementedException();
        }

        void DoUpdates()
        {
            throw new NotImplementedException();
        }

        void DoOutputs()
        {
            throw new NotImplementedException();
        }
    }
}