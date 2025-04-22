using System;
using System.Globalization;

class Exercicio1{

    static void Main(){

        Console.WriteLine("Crie sua senha: ");
        string senha = Console.ReadLine();

        if (senha.Length >= 8 && senha.IndexOfAny("ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()) != -1 &&
            senha.IndexOfAny("0123456789".ToCharArray()) != -1 && 
            senha.IndexOfAny("!@#$%^&*(),.?\":{}|<>".ToCharArray()) != -1){
            Console.WriteLine("Senha válida!");
        }else{
            Console.WriteLine("Senha inválida. Certifique-se de que ela atende aos critérios.");
        }
    }
}