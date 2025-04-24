using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    public class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");

                for (int j = 0; j < tab.colunas; j++)
                {
                    imprimirPeca(tab.peca(i, j));
                }
                Console.WriteLine("");
            }
            Console.WriteLine("  a b c d e f g h");
        }

        internal static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine(); // ENTRAR COM LETRA E NÚMERO (POSIÇÃO DE XADREZ) ex.: c1
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        internal static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");

                for (int j = 0; j < tab.colunas; j++)
                {
                    // DESTACA A COR DO BACKGROUND DAS POSIÇÕES POSSÍVEIS
                    Console.BackgroundColor = posicoesPossiveis[i, j] ? fundoAlterado : fundoOriginal;
                    //if (posicoesPossiveis[i, j])
                    //{
                    //    Console.BackgroundColor = fundoAlterado;
                    //}
                    //else
                    //{
                    //    Console.BackgroundColor = fundoOriginal;
                    //}

                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine("");
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }

        }
    }
}
