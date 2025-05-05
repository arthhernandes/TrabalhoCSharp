using System;
using System.Globalization;

class Exercicio4{

    static void Main(){

        int opcao;
        
        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.WriteLine("3 - Sair");
            Console.Write("Opção: ");
            
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a temperatura em Celsius: ");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit}°F\n");
                    break;
                
                case 2:
                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    double fahr = double.Parse(Console.ReadLine());
                    double cel = (fahr - 32) * 5 / 9;
                    Console.WriteLine($"Temperatura em Celsius: {cel}°C\n");
                    break;
                
                case 3:
                    Console.WriteLine("Saindo...");
                    break;
                
                default:
                    Console.WriteLine("Opção inválida, tente novamente.\n");
                    break;
            }
        } while (opcao != 3);

    }
}
