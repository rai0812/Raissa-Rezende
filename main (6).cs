/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/


using System;

namespace atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um código DDD:");
            int ddd = Convert.ToInt32(Console.ReadLine());

            string cidade;

            switch (ddd)
            {
                case 61:
                    cidade = "Brasília";
                    break;
                case 71:
                    cidade = "Salvador";
                    break;
                case 11:
                    cidade = "São Paulo";
                    break;
                case 21:
                    cidade = "Rio de Janeiro";
                    break;
                case 32:
                    cidade = "Juiz de Fora";
                    break;
                default:
                    cidade = "DDD não cadastrado";
                    break;
            }

            Console.WriteLine(cidade);

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}