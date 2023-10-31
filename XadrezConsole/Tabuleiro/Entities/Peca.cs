using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezConsole.Tabuleiro.Entities.Enums;

namespace XadrezConsole.Tabuleiro.Entities
{
    abstract class Peca
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

        public void IncrementarQtdMovimentos() {
            QtdMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < Tabuleiro.Linhas; i++) {
                for (int j = 0; j < Tabuleiro.Colunas; j++) {
                    if (mat[i, j]) { 
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos) {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

    }
}
