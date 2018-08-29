using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanWork
{
    /*
     *  Classe Cartao
     *  Responsável por gerenciar os dados relacionado a cartões
     */
    class Cartao
    {
        enum cartaoBandeira {AMEX, Discover, MasterCard, VISA, Desconhecido };

        private string tipoCartaoBandeira{ get; set; }
        private string nome { get; set; }
        private string numero { get; set; }
        private string  anoVencimento { get; set; }
        private string mesVencimento { get; set; }

        public Cartao(string numero, string anoVencimento, string mesVencimento, string nome)
        {
            this.numero             = numero.Replace(" ", "").Replace(" ", "");
            this.anoVencimento      = anoVencimento;
            this.mesVencimento      = mesVencimento;
            this.nome               = nome;
        }

        //Verificar se o cartão é válido
        public bool isValid()
        {
            return helpers.Helpers.luhn(this.numero);
        }

        //Executar o desafio
        public string execute()
        {

            string result = "";
            string valido = "inválido";
            int numeroComprimento = this.numero.Length;
            IEnumerable<CartaoTipo> cartaoTipos = new List<CartaoTipo>
            {
                new CartaoTipo(cartaoBandeira.AMEX.ToString(), "34", 15),
                new CartaoTipo(cartaoBandeira.AMEX.ToString(), "37", 15),
                new CartaoTipo(cartaoBandeira.Discover.ToString(), "6011", 16),
                new CartaoTipo(cartaoBandeira.MasterCard.ToString(), "51", 16),
                new CartaoTipo(cartaoBandeira.MasterCard.ToString(), "55", 16),
                new CartaoTipo(cartaoBandeira.VISA.ToString(), "4", 13),
                new CartaoTipo(cartaoBandeira.VISA.ToString(), "4", 16),
            };

            //Define label valido
            if (isValid())
                valido = "válido";

            //Ordenar os registros com mais caracteres para os com menos caracter
            cartaoTipos = cartaoTipos.OrderByDescending(t => t.iniciaCom.Length);

            //Verificar em qual tipo de cartao este se enquadra
            foreach(CartaoTipo tipo in cartaoTipos)
            {
                //Verificar se a quantidade de caracteres é igual E se as iniciais são iguais
                if (tipo.numeroComprimento == numeroComprimento && tipo.iniciaCom.Equals(this.numero.Substring(0, tipo.iniciaCom.Length)))
                    result = tipo.bandeira + ": " + this.numero + " (" + valido + ")";
            }

            //Caso não tenha encontrado nenhum cartão na lista, ele é desconhecido
            if(result.Length == 0)
                result = cartaoBandeira.Desconhecido.ToString() + ": " + this.numero + " (" + valido + ")";

            return result;
        }

    }
}
