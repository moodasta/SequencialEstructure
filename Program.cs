using System;
using System.Globalization;
//formatação numérica 

//agrupa as classes relacionadas
namespace SegundoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarando variáveis do tipo double (números com parte inteira e decimal)
            double raio, area;
            double pi = 3.14159;

            Console.Write("Digite o valor do raio do círculo: ");
            //ler a entrada do usuário a partir do console
            string input = Console.ReadLine();

            //converter a string input em um valor numérico do tipo double e atribuí-lo à variável raio.
            if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out raio))
            {
                //calcula a área de um círculo com base no valor do raio
                area = pi * Math.Pow(raio, 2);

                //imprime a mensagem contendo o valor da área do círculo com quatro casas decimais.
                Console.WriteLine("A área do círculo é: " + area.ToString("F4", CultureInfo.InvariantCulture));
            }
            //valor inserido pelo usuário para o raio do círculo não é válido.
            else
            {
                Console.WriteLine("Valor inválido para o raio do círculo.");
            }
        }
    }
}





