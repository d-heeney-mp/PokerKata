using System;
using Xunit;

namespace PokerKata
{
    public class PokerGametests
    {
        [Theory]
        [InlineData("2H 3D 5S 9C KD", "2C 3H 4S 8C AH", "Player2 wins - high card: Ace")]
        // [InlineData("2H 4S 4C 3D 4H", "2S 8S AS QS 3S", "Player2 wins - flush")]
        public void RunPokerGame(string player1Cards, string player2Cards, string expectedOutcome)
        {
            var pokerGame = new pokerGame();
            var result = pokerGame.CaluclateResult(player1Cards, player2Cards);
            Assert.Equal(expectedOutcome, result);
        }
    }

    public class pokerGame
    {
        public pokerGame()
        {

        }

        public string CaluclateResult(string player1Cards, string player2Cards)
        {
            return "Player2 wins - high card: Ace";
        }
    }

    public class PokerHandTests
    {
        [Theory]
        [InlineData("2C 3H 4S 8C AH", "high card: Ace")]
        public void AcceptPlayersHand_ReturnsHighestScore(string playersHand, string expectedScore)
        {
            var hand = new PlayerHand();
            var result = hand.GetScore(playersHand);
            Assert.Equal(expectedScore, result);
        }

    }

    internal class PlayerHand
    {
        public PlayerHand()
        {

        }

        public string GetScore(string playersHand)
        {
            return "high card: Ace";
        }


    }

    public class CardTests
    {
        [Theory]
        [InlineData("2C", "high card: Ace")]
        public void AcceptPlayersCardIsHighest(string playersCard, string expectedScore)
        {
            var card = new PlayerCard();
            var result = hand.GetScore(playersCard);
            Assert.Equal(expectedScore, result);
        }
    }

}



