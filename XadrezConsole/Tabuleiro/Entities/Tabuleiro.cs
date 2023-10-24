using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XadrezConsole.Tabuleiro.Entities
{
    internal class TipoTabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] _pecas;//apenas o tabuleiro mexe nesse atributo

        public TipoTabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            _pecas = new Peca[Linhas, Colunas]; //instanciando a matriz
        }

        public Peca Peca(int linha, int coluna) // retorna a peça individual em determinada posicao
        {
            return _pecas[linha, coluna];
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            _pecas[pos.Linha, pos.Coluna] = p; //adicionando peça em tal posicao da matriz
            p.Posicao = pos; //adicionando posição tal na peça
        }
    }
}
