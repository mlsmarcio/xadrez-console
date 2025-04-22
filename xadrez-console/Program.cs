using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.Tab);

                    Console.WriteLine("");
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }



                //// TESTE MÉTODO toPosicao() que converte a posição do xadrez para posição da matriz
                //PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                //Console.WriteLine(pos);
                //Console.WriteLine(pos.toPosicao());
                //Console.ReadLine();

            }
            catch (TabuleiroException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

        /*
            CAMADAS:
                APLICAÇÃO
                TABULEIRO
                JOGO DE XADREX
         */
    }
}
