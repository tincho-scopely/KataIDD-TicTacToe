namespace Kata.Scripts.IDD.Domain.Model
{
    public class Game
    {
        private readonly int[,] _board;

        public Game(int[,] board)
        {
            _board = board;
        }

        #region Equality Members

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Game) obj);
        }

        private bool Equals(Game other)
        {
            return Equals(_board, other._board);
        }

        #endregion
    }
}