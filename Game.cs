using System;

namespace TicSharpToe
{
    public class Game
    {
        public Game(Player p1, Player p2)
        {
            this.playerOne = p1;
            this.playerTwo = p2;
            Console.WriteLine("Game initialized");
            Console.WriteLine("Player 1 symbol : " + this.playerOne.Symbol.ToString());
            Console.WriteLine("Player 2 symbol : " + this.playerTwo.Symbol.ToString());
            
        }

        public void Play()
        {
            Console.WriteLine("Starting game");
            Console.WriteLine("Ending game");
        }

        private Player playerOne;
        private Player playerTwo;
    }
}