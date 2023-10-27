using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezConsole.Tabuleiro.Entities.Exceptions;

namespace XadrezConsole.Tabuleiro.Entities
{
    internal class TipoTabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] _peca;//apenas o tabuleiro mexe nesse atributo / todas as casas são peças, porém vazias ou preenchidas

        public TipoTabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            _peca = new Peca[Linhas, Colunas]; //instanciando uma matriz do tipo peça
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Já existe peça nessa posição!");
            }
            _peca[pos.Linha, pos.Coluna] = p; //adicionando peça em tal posicao da matriz
            p.Posicao = pos; //adicionando posição tal na peça
        }

        public Peca RetirarPeca(Posicao pos) {
            if (!ExistePeca(pos))
            {
                return null;
            }
            Peca aux = Peca(pos);
            aux.Posicao = null;
            _peca[pos.Linha, pos.Coluna] = null; //limpando posição do tabuleiro
            return aux; //retornando peça retirada e com posição nula
        }

        public Peca Peca(Posicao pos)
        { //retorna a peça na posição poslinha e poscoluna
            return _peca[pos.Linha, pos.Coluna];
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
