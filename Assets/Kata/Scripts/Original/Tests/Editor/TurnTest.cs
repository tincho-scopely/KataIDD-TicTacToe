using Kata.Scripts.Original.Domain;
using NUnit.Framework;

namespace Kata.Scripts.Original.Tests.Editor
{
    [TestFixture]
    public class TurnTest
    {
        private Turn turn;
    
        [SetUp]
        public void SetUp()
        {
            turn = new Turn();
        }

        [Test] //Requirements are uncompleted, I made this requirement up myself
        public void WhenTheGameIsInitialized_ThenFirstTurnIsPlayerO()
        {
            Assert.That(turn.GetPlayerTurn(), Is.EqualTo(Player.O));
        }
    
        [Test]
        public void WhenCallChangeTurn_ThenChangeThePlayer()
        {
            turn.ChangeTurn();
            Assert.That(turn.GetPlayerTurn(), Is.EqualTo(Player.X));
            turn.ChangeTurn();
            Assert.That(turn.GetPlayerTurn(), Is.EqualTo(Player.O));
        }
    }
}
