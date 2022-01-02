﻿namespace tabuleiro
{
    internal class Peca
    {
        public Posicao  posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
           posicao = null;
           Cor = cor;
           tab = tab;
           QteMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            QteMovimentos++;
        }


    }
}
