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
                //Tabuleiro tab = new Tabuleiro(8, 8);

                //tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                //tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
                //tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                //Tela.imprimirTabuleiro(tab);

                // TESTE MÉTODO toPosicao() que converte a posição do xadrez para posição da matriz
                PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                Console.WriteLine(pos);
                Console.WriteLine(pos.toPosicao());
                Console.ReadLine();

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
