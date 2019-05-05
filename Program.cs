using System;

namespace TicSharpToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.Play();
        }
    }
}