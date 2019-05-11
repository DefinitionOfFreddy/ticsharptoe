using System;
using System.Collections.Generic;

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
            board = new Dictionary<Position, Symbol>();
            board[Position.NORTHWEST] = Symbol.None;
            board[Position.NORTH] = Symbol.None;
            board[Position.NORTHEST] = Symbol.None;
            board[Position.WEST] = Symbol.None;
            board[Position.CENTER] = Symbol.None;
            board[Position.EST] = Symbol.None;
            board[Position.SOUTHWEST] = Symbol.None;
            board[Position.SOUTH] = Symbol.None;
            board[Position.SOUTHEST] = Symbol.None;
        }

        public void Play()
        {
            Console.WriteLine("Starting game");
            Console.WriteLine("Board Status :");
            Console.WriteLine(this.BoardToString());
            Console.WriteLine("Ending game");
        }

        private string BoardToString()
        {
            return "| "  + board[Position.NORTHWEST].ToString() +
                            " | " + board[Position.NORTH].ToString() +
                            " | " + board[Position.NORTHEST].ToString() +
                            " |\n" +
                            "| " + board[Position.WEST].ToString() +
                            " | " + board[Position.CENTER].ToString() +
                            " | " + board[Position.EST].ToString() +
                            " |\n" +
                            "| " + board[Position.SOUTHWEST].ToString() +
                            " | " + board[Position.SOUTH].ToString() +
                            " | " + board[Position.SOUTHEST].ToString() +
                            " |";
        }
        
        private Player playerOne;
        private Player playerTwo;
        private Dictionary<Position, Symbol> board;
    }
}