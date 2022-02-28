
namespace tabuleiro
{
    class Posicao
    {
        //auto properties
        public int linha { get; set; }
        public int coluna { get; set; }

        //construtor
        public Posicao(int linha, int coluna)
        {
            this.linha = linha;  //this = autorreferência
            this.coluna = coluna;   
        }
        
        //Sobreposição
        public override string ToString()
        {
            return linha
                + ", "
                + coluna;
        }
    }
}
