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

            try
            {
                TipoTabuleiro tab = new TipoTabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));

                Tela.ImprimirTabuleiro(tab);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}