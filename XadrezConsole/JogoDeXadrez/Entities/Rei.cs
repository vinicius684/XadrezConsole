using XadrezConsole.Tabuleiro.Entities;
using XadrezConsole.Tabuleiro.Enums;

namespace XadrezConsole.JogoDeXadrez.Entities
{
    internal class Rei : Peca
    {
  
        public Rei(TipoTabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "R";
        }
    }
}
