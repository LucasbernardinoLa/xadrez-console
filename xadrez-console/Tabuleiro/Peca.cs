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

        public abstract bool[,] movimentosPossiveis();
        

        

    }
}
