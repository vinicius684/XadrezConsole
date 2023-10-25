using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezConsole.Tabuleiro.Entities;

namespace XadrezConsole
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(TipoTabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Peca(new Posicao(i, j)) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.Peca(new Posicao(i, j)) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
