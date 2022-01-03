using tabuleiro;

namespace xadrez
{
    internal class Bispo : Peca
    {
        public Bispo(Tabuleiro tab, Cor cor)
            : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "B";
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            //No
            pos.definirValores(posicao.Linha - 1, posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna - 1);
            }
            //Ne
            pos.definirValores(posicao.Linha - 1, posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna + 1);
            }
            //So
            pos.definirValores(posicao.Linha + 1, posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha + 1, pos.Coluna - 1);
            }
            //Se    
            pos.definirValores(posicao.Linha + 1, posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha + 1, pos.Coluna + 1);
            }
            return mat;
        }


        private bool podeMover(Posicao pos)
        {
            Peca p = Tabuleiro.Peca(pos);
            return p == null || p.Cor != Cor;
        }
    }
}