using System;
using System.Collections.Generic;
using System.Text;

namespace Trying_to_figure_out_errors
{
    class Produto
    {
        public Produto(string codproduto, string designacao, double preco, int stock, double iva)
        {
            this.codproduto = codproduto;
            this.designacao = designacao;
            this.preco = preco;
            this.stock = stock;
        }

        private string codproduto;
        private string designacao;
        private double preco;
        private int stock;

        public string CodProduto
        {
            get { return codproduto; }
            set { codproduto = value; }
        }

        public string Designacao
        {
            get { return designacao; }
            set { designacao = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public int Quantidade
        {
            get { return stock; }
            set { stock = value; }
        }
    }
}
