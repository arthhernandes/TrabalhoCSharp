using System;
using System.Collections.Generic;
class Exercicio10{
    static void Main(){
        List<string> tarefas = new List<string>();
        List<bool> concluidas = new List<bool>();
        int opcao;

        do
        {
            Console.WriteLine("\nLista de Tarefas:");
            Console.WriteLine("1 - Adicionar Tarefa");
            Console.WriteLine("2 - Marcar Tarefa como Concluída");
            Console.WriteLine("3 - Listar Tarefas");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a nova tarefa: ");
                    tarefas.Add(Console.ReadLine());
                    concluidas.Add(false);
                    Console.WriteLine("Tarefa adicionada!");
                    break;

                case 2:
                    Console.WriteLine("Tarefas disponíveis:");
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} - {tarefas[i]} {(concluidas[i] ? "(Concluída)" : "")}");
                    }

                    Console.Write("Digite o número da tarefa concluída: ");
                    int indice = int.Parse(Console.ReadLine()) - 1;

                    if (indice >= 0 && indice < tarefas.Count)
                    {
                        concluidas[indice] = true;
                        Console.WriteLine("Tarefa marcada como concluída!");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                    break;

                case 3:
                    Console.WriteLine("\nLista de Tarefas:");
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} - {tarefas[i]} {(concluidas[i] ? "(Concluída)" : "(Pendente)")}");
                    }
                    break;

                case 4:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }
        } while (opcao != 4);

    }
}


