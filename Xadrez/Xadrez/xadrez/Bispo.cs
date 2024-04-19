using Xadrez.tabuleiro;

namespace Xadrez.xadrez
{
    internal class Bispo : Peca
    {
        public Bispo(Tabuleiro tab, Cor cor) : base(tab, cor)
        { }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);

            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //Diagonal Superior Esquerda
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }

                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            }

            //Diagonal Superior Direito
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }

                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            }

            //Diagonal Inferior Esquerada
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }

                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            }

            //Diagonal Inferior Direito
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }

                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            }

            return mat;
        }

        public override string ToString()
        {
            return "B";
        }
    }
}
