using Kata.Scripts.IDD.Domain.Model;

namespace Kata.Scripts.IDD.Tests.Editor.Mothers
{
    public static class GameMother
    {
        public static Game AGame(int[,] withBoard = null)
        {
            return new Game(
                withBoard ?? new int[1,1]
            );
        }
    }
}