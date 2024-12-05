/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
namespace atividade1
{
class Program
{
    static void Main()
    {
    
        Console.Write("Digite um valor inteiro (0 < N < 1000000): ");
        int N = int.Parse(Console.ReadLine());

    
        if (N > 0 && N < 1000000)
        {
            Console.WriteLine(N); 

        
            int[] notas = { 100, 50, 20, 10, 5, 2, 1 };

            
            foreach (int nota in notas)
            {
                int quantidade = N / nota; 
                Console.WriteLine($"{quantidade} nota(s) de R$ {nota},00");
               N %= nota; 
            }
        }
        else
        
            Console.WriteLine("Valor fora do intervalo permitido.");
    }
}
        
}