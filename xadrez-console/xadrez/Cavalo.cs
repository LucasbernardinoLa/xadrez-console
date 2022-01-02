using tabuleiro;

namespace xadrez
{
    internal class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor)
            : base(tab, cor)
        {
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            
            pos.definirValores(posicao.Linha - 1, posicao.Coluna - 2);
            if (Tabuleiro.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            
            pos.definirValores(posicao.Linha - 2, posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            
            pos.definirValores(posicao.Linha - 2, posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            
            pos.definirValores(posicao.Linha - 1, posicao.Coluna + 2);
            if (Tabuleiro.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(posicao.Linha + 1, posicao.Coluna + 2);
            if (Tabuleiro.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            
            pos.definirValores(posicao.Linha + 2, posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            
            pos.definirValores(posicao.Linha + 2, posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            
            pos.definirValores(posicao.Linha + 1, posicao.Coluna - 2);
            if (Tabuleiro.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            return mat;
        }


        private bool podeMover(Posicao pos)
        {
            Peca p = Tabuleiro.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override string ToString()
        {
            return "C";
        }


    }
}
