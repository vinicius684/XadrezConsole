using XadrezConsole.Tabuleiro.Entities;

namespace XadrezConsole.JogoDeXadrez.Entities
{
    internal class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha) { 
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao() {
            return new Posicao(8 - Linha, Coluna - 'a'); //internamente 'a'(1) é uma numero b - a = pos 1.... /  8 - 7 = pos 1
        }

        public override string ToString()
        {
            return "" + Linha + Coluna;
        }
    }
}
