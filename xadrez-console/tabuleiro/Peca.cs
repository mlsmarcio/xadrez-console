namespace tabuleiro
{
    public abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; } // PODE SER ALTERADO POR ELA MESMA E PELAS SUBCLASSES DELA
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0;
        }

        public void IncrementarMovimentos()
        {
            qteMovimentos++;
        }

        // NÃO É POSSÍVEL IMPLEMENTAR O MÉTODO NESSA CLASSE GENÉRICA. DEFINI-SE O MÉTODO COMO ABASTRATO
        // ENTÃO A CLASSE PASSA A SER ABSTRATA PORQUE PARA ISSO É NECESSÁRIO TER PELO MENOS UM MÉTODO ABSTRATO
        public abstract bool[,] movimentosPossiveis();

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos) {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }
    }
}
