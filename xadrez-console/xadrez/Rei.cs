using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public Rei(Tabuleiro tab, Cor cor, Posicao pos) : base(tab, cor)
        {
            
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
