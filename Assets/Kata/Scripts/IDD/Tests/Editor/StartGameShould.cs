using Kata.Scripts.IDD.Domain.Actions;
using Kata.Scripts.IDD.Domain.Model;
using Kata.Scripts.IDD.Domain.Repositories;
using NSubstitute;
using NUnit.Framework;
using static Kata.Scripts.IDD.Tests.Editor.Mothers.GameMother;

namespace Kata.Scripts.IDD.Tests.Editor
{
    [TestFixture]
    public class StartGameShould 
    {
        private readonly int[,] EXPECTED_BOARD = new int[3,3];
        private StartGame action;
        private BoardRepository boardRepository;
        private Game result;

        [SetUp]
        public void Setup()
        {
            boardRepository = Substitute.For<BoardRepository>();
            action = new StartGame(boardRepository);
        }
        
        [Test]
        public void Initialize_With_A_3_X_3_Board()
        {
            GivenABoardWith(EXPECTED_BOARD);
            WhenExecuting();
            ThenGameIs(AGame(withBoard: EXPECTED_BOARD));
        }

        private void GivenABoardWith(int[,] expectedBoard)
        {
            boardRepository.Get().Returns(expectedBoard);
        }

        private void WhenExecuting()
        {
            result = action.Execute();
        }

        private void ThenGameIs(Game expected)
        {
            Assert.AreEqual(result, expected);
        }
    }
}
