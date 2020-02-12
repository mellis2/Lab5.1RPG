using System;
using System.Collections.Generic;
using System.Text;

namespace Trying_to_figure_out_errors
{
    class Software : Produto
    {
        //public Software(string marca, string sistemaoperativo, string tiposoftware)
        public Software(string marca, string sistemaoperativo, string tiposoftwarestring codproduto, string designacao, double preco, int stock, double iva) : base(designacao, preco, stock, iva)
        {
            this.marca = marca;
            this.sistemaoperativo = sistemaoperativo;
            this.tiposoftware = tiposoftware;
        }

        private string marca;
        private string sistemaoperativo;
        private string tiposoftware;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string SistemaOperativo
        {
            get { return sistemaoperativo; }
            set { sistemaoperativo = value; }
        }

        public string TipoSoftware
        {
            get { return tiposoftware; }
            set { tiposoftware = value; }
        }
    }
}
