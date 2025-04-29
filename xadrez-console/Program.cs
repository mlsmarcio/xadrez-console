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
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirPartida(partida);

                        Console.WriteLine("");
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.ValidarPosicaoOrigem(origem);

                        // IMPRIME AS POSIÇÕES POSSÍVEIS
                        bool[,] posicoesPossiveis = partida.Tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.Tab, posicoesPossiveis);

                        Console.WriteLine("");
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                Tela.ImprimirPartida(partida);



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
