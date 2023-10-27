using XadrezConsole.Tabuleiro.Entities;
using XadrezConsole.Tabuleiro.Entities.Enums;

namespace XadrezConsole.JogoDeXadrez.Entities
{
    internal class Torre : Peca
    {
        public Torre(TipoTabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "T";
        }
    }
}
