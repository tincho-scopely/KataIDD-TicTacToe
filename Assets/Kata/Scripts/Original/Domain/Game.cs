namespace Kata.Scripts.Original.Domain
{
    public class Game
    {
        private Board board;
        private Turn turn;
        private int size = 3;
        public Game()
        {
            board = new Board(size);
            turn = new Turn();
        }

        public void Take(int row, int column)
        {
            board.Take(row, column, turn.GetPlayerTurn());
        }
    
        public bool IsOver()
        {
            return board.IsOver();
        }

        public void ChangeTurn()
        {
            turn.ChangeTurn();
        }

        public bool CanTake(int row, int column)
        {
            return board.FieldCanBeTaken(row, column);
        }
    }
}
