using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanWork.helpers
{
    /* 
     *  Classe Helpers
     *  Classe responsável por centralizar todos os métodos que possam ser utilizados no projeto
     */
    class Helpers
    {
        /*
         *  Algoritmo Luhn
         */
        public static bool luhn(string texto)
        {
            /* 
             *  Descrição de váriaveis
             *      caracteres: Recebe a string invertida, utilizando o método Helpers.reverseString(string) (ex: "andy" => "ydna")
             *      i: Váriavel de controle de qual caracter está no foreach, deve iniciar em 1
             *      sum: Váriavel responsável pela soma total dos elementos         
             *      result: Váriavel responsável por amazenar o resultado do método 
            */
            string caracteres = Helpers.reverseString(texto);
            int i = 1;
            int sum = 0;
            bool result = false;

            foreach (char x in caracteres.ToArray())
            {
                int value = int.Parse(x.ToString());

                //Criar Exception caso não seja valor númerico
                if(!Helpers.isNumeric(x.ToString()))
                    throw new System.ArgumentException("O parâmetro do método luhn deve conter apenas números");

                //Se for um número par, faça
                if (Helpers.isEvenInt(i))
                {
                    //Multiplique o número por 2
                    value = int.Parse(x.ToString()) * 2;
                    
                    //Se for maior que 9, subtraia o valor por 9
                    if (value > 9)
                        value = value - 9;

                }//if (Helpers.isEvenInt(i))

                i++;
                sum += value;
            }//foreach (char x in caracteres.ToArray())

            //Se for divisor de 10, então é válido
            if (sum % 10 == 0)
                result = true;

            //retorna o resultado da função
            return result;
        }

        //Inverter a string (ex: "andy" => "ydna")
        public static string reverseString(string text)
        {
            //Converter String em um array de char
            char[] arrChar = text.ToCharArray();

            //Inverter as posições(ex: "andy" => "ydna")
            Array.Reverse(arrChar);

            //Retornar string
            return new String(arrChar);
        }

        //Verificar se o valor é Par
        public static bool isEvenInt(int value)
        {   //se for divisor de 2, é par
            if (value % 2 == 0)
                return true;
            else
                return false;
        }

        //Verifica se uma string é númerica
        public static bool isNumeric(string value)
        {
            double aux = 0;
            return double.TryParse(value, out aux);
        }
    }
}
