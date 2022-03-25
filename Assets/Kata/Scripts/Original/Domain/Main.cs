using System;

namespace Kata.Scripts.Original.Domain
{
    public class Main
    {
        private readonly Game game;
        private Random random;
    
        private const int MAX_DIMENSION = 3;
        public Main()
        {
            game = new Game();
            random = new Random();
        }
    
        public void Play()
        {
            do
            {
                int row = random.Next(0, MAX_DIMENSION);
                int column = random.Next(0, MAX_DIMENSION);

                if (game.CanTake(row, column))
                {
                    game.Take(1, 1);
                    game.ChangeTurn();
                }
            }
            while (!game.IsOver()) ;
        }
    }
}
