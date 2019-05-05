namespace TicSharpToe
{
    public class Player
    {
        public Player(Symbol symbol)
        {
            _symbol = symbol;
        }

        public Symbol Symbol => _symbol;

        private Symbol _symbol;
    }
}