using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezConsole.Tabuleiro.Exceptions;

namespace XadrezConsole.Tabuleiro.Entities
{
    internal class TipoTabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] _quadrados;//apenas o tabuleiro mexe nesse atributo / quadrados tem que caber no tipo Peca

        public TipoTabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            _quadrados = new Peca[Linhas, Colunas]; //instanciando uma matriz do tipo peça
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Já existe peça nessa posição!");
            }
            _quadrados[pos.Linha, pos.Coluna] = p; //adicionando peça em tal posicao da matriz
            p.Posicao = pos; //adicionando posição tal na peça
        }

        public Peca Peca(Posicao pos)
        { //retorna a peça na posição poslinha e poscoluna
            return _quadrados[pos.Linha, pos.Coluna];
        }

        public bool PosicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }

        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return Peca(pos) != null;
        }

    }
}
