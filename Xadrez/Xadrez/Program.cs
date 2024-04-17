using System;
using Xadrez.tabuleiro;
using Xadrez.xadrez;

namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PosicaoXadrez posX;

                posX = new PosicaoXadrez('a', 1);

                Console.WriteLine(posX);

                Console.WriteLine(posX.toPosicao());
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
