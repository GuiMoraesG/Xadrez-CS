using System;
using Xadrez.tabuleiro;

namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab;

            tab = new Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
