namespace Kata.Scripts.Original.Domain
{
    public class Board
    {
        private Player[,] grid;
        public Board(int size)
        {
            grid = new Player[size, size];
        }

        public int Size => grid.Length;

        public Player GetField(int row, int column)
        {
            return grid[row, column];
        }

        public void Take(int row, int column, Player player)
        {
            grid[row, column] = player;
        }

        public bool IsOver()
        {
            return IsAllFieldsFilled() || IsThereAWinner();
        }

        private bool IsAllFieldsFilled()
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == Player.None)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsThereAWinner() //It is public for testing purposes only
        {
            return HasWon(Player.O) || HasWon(Player.X);
        }
    
        private bool HasWon(Player player)
        {
            bool isOver = true;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                if (grid[i, 0] == player || grid[i, 0] == Player.None)
                {
                    isOver = false;
                }
            }

            return isOver;
        }


        public bool FieldCanBeTaken(int row, int column)
        {
            return GetField(row, column) == Player.None;
        }
    }
}
