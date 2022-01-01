namespace tabuleiro
{
    internal class Peca
    {
        public Posicao  posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
           posicao = posicao;
           cor = cor;
           tab = tab;
           QteMovimentos = 0;
        }
    }
}
