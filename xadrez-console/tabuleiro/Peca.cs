﻿namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }

        public int qteMovimentos { get; protected set; }

        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tabuleiro;
            qteMovimentos = 0;
        }
    }
}
