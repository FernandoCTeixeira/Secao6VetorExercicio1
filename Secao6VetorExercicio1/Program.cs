﻿using System;

namespace Exercicio1 {
    /*A dona de um pensionato possui dez quartos para alugar para estudantes,
sendo esses quartos identificados pelos números 0 a 9.

Quando um estudante deseja alugar um quarto, deve-se registrar o nome
e email deste estudante.

Fazer um programa que inicie com todos os dez quartos vazios, e depois
leia uma quantidade N representando o número de estudantes que vão
alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
N estudantes. Para cada registro de aluguel, informar o nome e email do
estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
um relatório de todas ocupações do pensionato, por ordem de quarto,
conforme exemplo.*/

    class Program {

        static void Main(string[] args) {

            Estudante[] quarto = new Estudante[10];

            Console.Write("Entre com a quantidade de quarto: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Aluguel #{i}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int id = int.Parse(Console.ReadLine());
                if (quarto[id] == null ) {
                    quarto[id] = new Estudante(nome, email);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Quartos ocupados:");
            for(int i = 1; i <= 10;i++) {
                if (quarto[i] != null) {
                    Console.WriteLine($"{i}: {quarto[i]}");
                }
            }
        }
    }
}
