﻿using System;
using Xadrez.tabuleiro;

namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao p;

            p = new Posicao(3, 4);

            Console.WriteLine(p);

            Console.ReadLine();
        }
    }
}
