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

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);

            Console.WriteLine();
        }
    }
}