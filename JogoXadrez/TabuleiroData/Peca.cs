namespace TabuleiroData
{
  abstract  class Peca
    {
        public Tabuleiro tab { get; protected set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Posicao posicao { get; set; }

        public Peca( Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;

        }

        public abstract bool[,] movimentosPossiveis();

    }
}
