using System;
using System.Globalization;

class Exercicio2{

    static void Main(){

        Console.WriteLine("Digite a tabuada que deseja saber: ");
        int tabuada = int.Parse(Console.ReadLine());

        for(int i = 0; i <= 10; i++){
            Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
        }
    }
}