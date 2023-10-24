using System;
using XadrezConsole;
using XadrezConsole.JogoDeXadrez.Entities;
using XadrezConsole.Tabuleiro.Entities;
using XadrezConsole.Tabuleiro.Enums;

namespace CSharpCursoNelioAlves.LogicaProgCSharp
{
    class EstruturaBasicaProgCSharp
    {
        static void Main(string[] args)
        {
            TipoTabuleiro tab = new TipoTabuleiro(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tab);

            
        }
    }
}