using tabuleiro;


namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;        
            Tab = tab;
            QuantidadeMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            QuantidadeMovimentos++;
        }
    }
}
