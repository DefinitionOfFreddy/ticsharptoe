using System;

namespace TicSharpToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player(Symbol.Circle);
            Player p2 = new Player(Symbol.Cross);
            Game game = new Game(p1, p2);
            game.Play();
        }
    }
}