
namespace tabuleiro
{
    class Posicao
    {
        //auto properties
        public int Linha { get; set; }
        public int Coluna { get; set; }

        //construtor
        public Posicao(int linha, int coluna)
        {
            Linha = linha;  //this = autorreferência
            Coluna = coluna;   
        }
        
        public void definirValores(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        //Sobreposição
        public override string ToString()
        {
            return Linha
                + ", "
                + Coluna;
        }


    }
}
