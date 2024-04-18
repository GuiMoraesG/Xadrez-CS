namespace Xadrez.tabuleiro
{
    internal abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QteMovimentos = 0;
        }

        public abstract bool[,] MovimentosPossiveis();

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();

            for (int l = 0; l < Tab.Linhas; l++)
            {
                for (int c = 0; c < Tab.Colunas; c++)
                {
                    if (mat[l, c])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool MovimentoPossivel(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public void IncrementarMovimento()
        {
            QteMovimentos++;
        }

        public void DecrementarMovimento()
        {
            QteMovimentos--;
        }
    }
}
