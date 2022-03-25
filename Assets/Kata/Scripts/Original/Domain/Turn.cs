using System;

namespace Kata.Scripts.Original.Domain
{
    public class Turn
    {
        private Player currentPlayer;
    
        public Turn()
        {
            currentPlayer = Player.O;
        }

        public Player GetPlayerTurn()
        {
            return currentPlayer;
        }
    
        public void ChangeTurn()
        {
            currentPlayer = (Player)(((int)currentPlayer) % (Enum.GetNames(typeof(Player)).Length-1) +1);
        }
    }
}
