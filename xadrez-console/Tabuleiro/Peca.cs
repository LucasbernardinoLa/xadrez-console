namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao  posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
           posicao = null;
           Cor = cor;
           Tabuleiro = tabuleiro;
           QteMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            QteMovimentos++;
        }

        public void DecrementarQteMovimentos()
        {
            QteMovimentos--;
        }

        public bool existeMovimentosPossivies()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i =0; i < Tabuleiro.Linhas; i++)
            {
                for (int j=0; j < Tabuleiro.Colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.Linha, pos.Coluna];
        }


        public abstract bool[,] movimentosPossiveis();
        

        

    }
}
