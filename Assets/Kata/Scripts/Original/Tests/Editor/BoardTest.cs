using Kata.Scripts.Original.Domain;
using NUnit.Framework;

namespace Kata.Scripts.Original.Tests.Editor
{
    [TestFixture]
    public class BoardTest
    {
        private Board board;
        private int size;
    
        [SetUp]
        public void SetUp()
        {
            size = 3;
            board = new Board(size);
        }
    
        [Test] // It has the public property Size that it is only used for the test
        public void WhenTheBoardIsCreated_ThenTheBoardHasNineGrid()
        {
            Assert.That(board.Size, Is.EqualTo(size*size));
        }

        [TestCase(Player.X)]
        [TestCase(Player.O)]
        public void WhenGetField_ThenHasToBeAnXOrO(Player player)
        {
            int row = 2;
            int column = 2;
        
            board.Take(row, column, player);
        
            Assert.That(board.GetField(row, column), Is.EqualTo(player));
        }

        [Test]
        public void WhenAllGridIsFilled_ThenTheGameIsOver()
        {
            board.Take(0,0, Player.O);
            board.Take(0,1, Player.O);
            board.Take(0,2, Player.O);
            board.Take(1,0, Player.O);
            board.Take(1,1, Player.O);
            board.Take(1,2, Player.O);
            board.Take(2,0, Player.O);
            board.Take(2,1, Player.O);
            board.Take(2,2, Player.O);
        
            Assert.That(board.IsOver(), Is.True);
        }
    
        [TestCase (Player.X)]
        [TestCase (Player.O)]
        public void WhenAPlayerFillOneColumn_ThenTheGameIsOver(Player player)
        {
            board.Take(0,0, player);
            board.Take(1,0, player);
            board.Take(2,0, player);
        
            Assert.That(board.IsOver(), Is.True);
        }
    
        [Test]
        public void WhenTheFieldIsNotEmpty_ThenTheFieldCannotBeTaken()
        {
            board.Take(0,0, Player.O);
        
            Assert.That(board.FieldCanBeTaken(0,0), Is.False);
            Assert.That(board.FieldCanBeTaken(1,0), Is.True);
        }
    }
}
