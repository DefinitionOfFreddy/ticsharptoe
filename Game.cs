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
            Console.WriteLine("Player 1 symbol : " + this.playerOne.Symbol.GetDescription());
            Console.WriteLine("Player 2 symbol : " + this.playerTwo.Symbol.GetDescription());
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
            this.getUserInput();
            Console.WriteLine("Ending game");
        }

        private string BoardToString()
        {
            return "| "  + board[Position.NORTHWEST].GetDescription() +
                            " | " + board[Position.NORTH].GetDescription() +
                            " | " + board[Position.NORTHEST].GetDescription() +
                            " |\n" +
                            "| " + board[Position.WEST].GetDescription() +
                            " | " + board[Position.CENTER].GetDescription() +
                            " | " + board[Position.EST].GetDescription() +
                            " |\n" +
                            "| " + board[Position.SOUTHWEST].GetDescription() +
                            " | " + board[Position.SOUTH].GetDescription() +
                            " | " + board[Position.SOUTHEST].GetDescription() +
                            " |";
        }



        private List<Position> getPossibleInput()
        {
            List<Position> list = new List<Position>();
            foreach (var item in this.board)
            {
                if (item.Value == Symbol.None)
                {
                    list.Add(item.Key);
                }
            }

            return list;
        }
        
        private string getPossibleInputString(List<Position> list)
        {
            string possibleValues = "|";
            foreach (var position in list)
            {
                possibleValues += " " + position.GetDescription() + " |";
            }
            return possibleValues;
        }

        
        private void getUserInput()
        {
            string userInput;
            List<Position> possibleInput = this.getPossibleInput();

            var statusInput = StatusCode.InputNotGiven;
            while (statusInput == StatusCode.InputNotGiven)
            {
                Console.WriteLine("Gimme your input !");
                Console.WriteLine("Possibles values are :");
                Console.WriteLine(this.getPossibleInputString(possibleInput));
                userInput = Console.ReadLine();
                Position position = possibleInput.Find(x => x.GetDescription().Equals(userInput));;

                if (position != Position.NONE)
                {
                    statusInput = StatusCode.InputValid;
                    Console.WriteLine(position.GetDescription());
                }

            }

        }
        
        private Player playerOne;
        private Player playerTwo;
        private Dictionary<Position, Symbol> board;
    }
}