using System;

namespace Xadrez.tabuleiro
{
    internal class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg) { }
    }
}
