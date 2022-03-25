using Kata.Scripts.Original.Domain;
using NUnit.Framework;

namespace Kata.Scripts.Original.Tests.Editor
{
    [TestFixture]
    public class GameTest
    {
        private Game game;
        
        [SetUp]
        public void SetUp()
        {
            game = new Game();
        }

        // [Test]
        // public void WhenAllFieldsInARowAreTakenByAPlayer_ThenTheGameIsOver()
        // {
        //     game.Take(0,0, Player.O);
        //     game.Take(1,0, Player.O);
        //     game.Take(2,0, Player.O);
        //     
        //     Assert.That(game.IsOver(), Is.EqualTo(true));
        // }
    
        [Test]
        public void WhenAllFieldsInARowAreTakenByAPlayer_ThenTheGameIsOver()
        {
            game.Take(0,0);
            game.Take(1,0);
            game.Take(2,0);
        
            Assert.That(game.IsOver(), Is.EqualTo(true));
        }
    }
}