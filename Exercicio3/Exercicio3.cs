using System;
using System.Globalization;
class Exercicio3{
    static void Main()
    {
        Console.WriteLine("Digite um número para calcular o fatorial:");
        int numero = int.Parse(Console.ReadLine());
        int fatorial = 1;

        while (numero > 1){
            fatorial *= numero;
            numero--;
        }

        Console.WriteLine($"O fatorial de {numero} é {fatorial}");
    }
}