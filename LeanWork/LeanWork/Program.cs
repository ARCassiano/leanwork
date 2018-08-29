using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanWork
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Cartao> cartaoes = new List<Cartao>
            {
                new Cartao("4111111111111111", "anoVenc", "mesVencimento", "nome"),
                new Cartao("4111111111111", "anoVenc", "mesVencimento", "nome"),
                new Cartao("4012888888881881", "anoVenc", "mesVencimento", "nome"),
                new Cartao("378282246310005", "anoVenc", "mesVencimento", "nome"),
                new Cartao("6011111111111117", "anoVenc", "mesVencimento", "nome"),
                new Cartao("5105105105105100", "anoVenc", "mesVencimento", "nome"),
                new Cartao("5105 1051 0510 5106", "anoVenc", "mesVencimento", "nome"),
                new Cartao("9111111111111111", "anoVenc", "mesVencimento", "nome"),
            };

            foreach(Cartao c in cartaoes)
                Console.WriteLine(c.execute());

            Console.ReadKey();
        }
    }
}
