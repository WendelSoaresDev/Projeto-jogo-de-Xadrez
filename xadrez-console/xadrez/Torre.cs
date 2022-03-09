using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public Torre(Tabuleiro tab, Cor cor, Posicao pos) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
