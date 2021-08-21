using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Calculadora do console em C#\r");
            Console.WriteLine("----------------------------\n");

            Console.WriteLine("Digite um número e pressione Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número e pressione Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha uma opção na lista a seguir: ");
            Console.WriteLine("\ta - Adição");
            Console.WriteLine("\ts - Subtração");
            Console.WriteLine("\tm - Multiplicação");
            Console.WriteLine("\td - Divisão");
            Console.Write("Qual Sua Opção? ");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Seu resultado: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Seu resultado: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Seu resultado: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Seu resultado: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            Console.Write("Pressione qualquer tecla para fechar o aplicativo do console da Calculadora ...");
            Console.ReadKey();
        }
    }
}
