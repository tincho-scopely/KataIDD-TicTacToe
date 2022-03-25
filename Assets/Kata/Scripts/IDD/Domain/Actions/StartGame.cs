using Kata.Scripts.IDD.Domain.Model;
using Kata.Scripts.IDD.Domain.Repositories;

namespace Kata.Scripts.IDD.Domain.Actions
{
    public class StartGame
    {
        private readonly BoardRepository boardRepository;

        public StartGame(BoardRepository boardRepository)
        {
            this.boardRepository = boardRepository;
        }

        public Game Execute() => new Game(boardRepository.Get());
    }
}