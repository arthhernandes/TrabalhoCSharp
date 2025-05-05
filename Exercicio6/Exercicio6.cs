using System;
using System.Linq;

class Exercicio6{
    static void Main(){
        Produto[] produtos = new Produto[3];

        for (int i = 0; i < 3; i++)
        {
            produtos[i] = new Produto();

            Console.WriteLine($"Cadastro do produto {i + 1}:");
            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produtos[i].Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
        }

        Console.WriteLine("\nLista de Produtos:");
        double totalEstoque = 0;

        foreach (var produto in produtos)
        {
            Console.WriteLine($"{produto.Nome} - R$ {produto.Preco} - {produto.Quantidade} unidades");
            totalEstoque += produto.ValorTotalEmEstoque();
        }

        Console.WriteLine($"\nValor total em estoque: R$ {totalEstoque}");
    }

}


