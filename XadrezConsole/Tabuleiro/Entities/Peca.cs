using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezConsole.Tabuleiro.Enums;

namespace XadrezConsole.Tabuleiro.Entities
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor CorPeca { get; set; }
        public int QtdMovimentos { get; protected set; }// so pode ser alterada por ela mesma e subclasses
        public TipoTabuleiro Tabuleiro { get; protected set; }

        public Peca() { }

        public Peca(TipoTabuleiro tabuleiro, Cor corPeca)
        {
            Posicao = null;
            CorPeca = corPeca;
            QtdMovimentos = 0;
            Tabuleiro = tabuleiro;
        }
    }
}
