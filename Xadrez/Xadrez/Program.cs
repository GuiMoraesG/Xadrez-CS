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
                Tabuleiro tab;

                tab = new Tabuleiro(8, 8);

                tab.AdicionarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.AdicionarPeca(new Torre(tab, Cor.Preta), new Posicao(2, 8));
                tab.AdicionarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 2));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
