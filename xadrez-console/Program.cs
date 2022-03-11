using System;
using tabuleiro;
using xadrez_console;
using xadrez;


try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();
    
    while (!partida.terminada)
    {
        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab);

        Console.WriteLine();
        Console.Write("Origem: ");
        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
        Console.Write("Destino: ");
        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

        partida.executaMovimento(origem, destino);
    }
    
    
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}





PosicaoXadrez pos = new PosicaoXadrez('a', 1);


Console.WriteLine(pos);

Console.WriteLine(pos.toPosicao());
    Console.ReadLine();

