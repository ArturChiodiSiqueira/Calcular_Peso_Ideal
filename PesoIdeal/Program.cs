using System;

namespace PesoIdeal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, pesoIdeal;
            char sexo, letraMaiuscula;
            bool comparacao;

            Console.Write("PARA CALCULAR SEU PESO IDEAL, INFORME SUA ALTURA (em metros): ");
            altura = double.Parse(Console.ReadLine());

            do
            {
                Console.Write("\nINFORME SEU SEXO (use 'M' para masculino e 'F' para feminino): ");
                sexo = char.Parse(Console.ReadLine());
                letraMaiuscula = char.ToUpper(sexo);

                if(letraMaiuscula == 'M')
                {
                    Console.WriteLine("você é do sexo masculino!");
                    pesoIdeal = (72.7 * altura) - 58;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n SEU PESO IDEAL É: " + pesoIdeal.ToString("F2") + "kg.");
                    Console.ForegroundColor = ConsoleColor.White;
                    comparacao = true;
                }
                else if(letraMaiuscula == 'F')
                {
                    Console.WriteLine("você é do sexo feminino!");
                    pesoIdeal = (62.1 * altura) - 44.7;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n SEU PESO IDEAL É: " + pesoIdeal.ToString("F2") + "kg.");
                    Console.ForegroundColor = ConsoleColor.White;
                    comparacao = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSEXO INVÁLIDO!!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    comparacao = false;
                }
            } while (comparacao != true);

            Console.WriteLine("\n\nPRESSIONE QUALQUER TECLA PARA SAIR.");
            Console.ReadKey();
        }
    }
}
