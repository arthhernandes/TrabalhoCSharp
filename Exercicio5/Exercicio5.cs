using System;
using System.Linq;

class Exercicio5{
    static void Main(){
        Console.Write("Digite uma palavra ou frase: ");
        string entrada = Console.ReadLine().ToLower().Replace(" ", "").Replace("-", "").Replace(",", "").Replace(".", "");

        string reverso = new string(entrada.Reverse().ToArray());

        Console.WriteLine(entrada == reverso ? "É um palíndromo!" : "Não é um palíndromo.");
    }
}

