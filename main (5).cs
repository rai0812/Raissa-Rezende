/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

using System.Globalization;

namespace atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira data (dd/MM/yyyy):");
            string data1String = Console.ReadLine();
            DateTime data1 = DateTime.ParseExact(data1String, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a segunda data (dd/MM/yyyy):");
            string data2String = Console.ReadLine();
            DateTime data2 = DateTime.ParseExact(data2String, "dd/MM/yyyy", CultureInfo.InvariantCulture);

          
            TimeSpan diferenca = data2 - data1;
            int dias = diferenca.Days;

           
            Console.WriteLine($"A quantidade de dias entre {data1.ToString("dd/MM/yyyy")} e {data2.ToString("dd/MM/yyyy")} é {dias} dias.");

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}