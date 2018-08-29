using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanWork
{
    /*
     * Classe CartaoTipo
     * Responsável por armazenar os dados de cada bandeira
     */
    class CartaoTipo
    {
        public string bandeira { get; set; }
        public string iniciaCom { get; set; }
        public int numeroComprimento { get; set; }

        public CartaoTipo(string bandeira, string iniciaCom, int numeroComprimento)
        {
            this.bandeira = bandeira;
            this.iniciaCom = iniciaCom;
            this.numeroComprimento = numeroComprimento;
        }
    }
}
