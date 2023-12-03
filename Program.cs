using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_04_For_Contagem_de_Vogais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra ou frase: ");
            string entrada = Console.ReadLine().ToUpper();

            int contadorVogais = 0;
            for (int i = 0; i < entrada.Length; i++)
            {
                char caractere = entrada[i];
                if (caractere == 'A' || caractere == 'E' || caractere == 'I' || caractere == 'O' || caractere == 'U')
                {
                    contadorVogais++;
                }
            }

            Console.WriteLine($"Número de vogais na entrada: {contadorVogais}");

            Console.ReadKey();
        }
    }
}
    
