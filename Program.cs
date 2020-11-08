using System;

namespace HeronSeTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.WriteLine("Bem-vindo ao Heron.");
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadKey();
            Console.WriteLine("\nDescubra o tipo de um triângulo dado os valores.");
            Console.WriteLine("\nPor favor, escolha números decimais");


            Console.Write("1o Número: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("2o Número: ");
            b = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("3o Número: ");
            c = Convert.ToDouble(Console.ReadLine());

            double soma02 = (a + b + c) / 2;

            double soma2 = soma02 - a;
            double soma3 = soma02 - b;
            double soma4 = soma02 - c;
            double soma5 = soma02 * soma2 * soma3 * soma4;
            double soma6=Math.Round(soma5);

            if(a<(b+c) && a > Math.Abs(b - c) && b <(a + c) 
             && b > Math.Abs(a - c) && c < (a + b) && c >   
             Math.Abs(a - b))
             Console.WriteLine("\nRela do triângulo:");
             
             Console.ForegroundColor = ConsoleColor.Green;
             if(a==b && b==a && a==c && c==a && b==c && c==b)
             Console.WriteLine($"Seu triângulo é equilátero"); 
             else if(a!=b && b!=a && a!=c && c!=a && b!=c && c!=b)
             Console.WriteLine("\nSeu triângulo é do tipo escaleno");
             else
             Console.WriteLine("\nSeu triângulo é do tipo isóceles");
             Console.ResetColor();

             Console.WriteLine($"\nA extensão do triângulo é: {soma6}");
        }
    }
}
