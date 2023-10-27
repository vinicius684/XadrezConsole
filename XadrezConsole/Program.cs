using System;
using XadrezConsole;
using XadrezConsole.JogoDeXadrez.Entities;
using XadrezConsole.Tabuleiro.Entities;
using XadrezConsole.Tabuleiro.Entities.Enums;

namespace CSharpCursoNelioAlves.LogicaProgCSharp
{
    class EstruturaBasicaProgCSharp
    {
        static void Main(string[] args)
        {

            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)//não estiver terminada
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tabuleiro);

                    Console.Write("Origem (ColunaLinha): ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino (ColunaLinha): ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.executaMovimento(origem, destino);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

    }
    }
}