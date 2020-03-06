using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {


            // Opção inicial - 2 opções: Criar Conta; Demais Operações


            List<ContaPoupanca> Poupanca = new List<ContaPoupanca>();
            List<ContaCorrente> Corrente = new List<ContaCorrente>();
            int recebedor = string.Empty;

            int a = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            double c = double.Parse(Console.ReadLine());

            while (true)
            {

                Console.WriteLine("Digite uma das opções. Para criar conta digite 1. Para fazer uma operação na conta digite 2;");
                recebedor = int.Parse(Console.ReadLine());
                if (recebedor.Equals("1"))
                {

                    Console.WriteLine("Qual tipo de conta deseja criar? Conta Poupança digite 1, Conta Corrente digite 2");

                    if (recebedor.Equals("1"))
                    {
                        Console.WriteLine("Poupanca");
                        Console.WriteLine("Digite os dados abaixo:");

                        Poupanca.Add(new ContaPoupanca { ID = a, Nome = b, Saldo = c });


                        Console.WriteLine("Conta Poupança criada com Sucesso. Criada com sucesso.");

                    }
                    else if(recebedor.Equals("2"))
                    {
                        Console.WriteLine("Corrente");
                        Console.WriteLine("Digite os dados abaixo:");
                        Corrente.Add(new ContaCorrente { ID = a, Nome = b, Saldo = c });

                        Console.WriteLine("Conta Corrente Criada com sucesso.");


                    }

                    Console.WriteLine("Criar conta digite os dados abaixo: ");

          





                }

                else if (recebedor.Equals("2"))
                    {
                    Console.WriteLine("Qual operação deseja fazer. Para Saque: 1, Depósito: 2, Transferência: 3.");

                    if(recebedor.Equals("1"))
                    {
                        Console.WriteLine("Saque");
                    }

                    else if (recebedor.Equals("2"))
                    {
                        Console.WriteLine("Depósito");
                    }


                    else if (recebedor.Equals("3"))
                    {
                        Console.WriteLine("Transferência");
                    }


                }


                Console.WriteLine("Para ir para o Menu iniciar digite 1, Para desligar digite 2.");


            }

        }
    }
}
