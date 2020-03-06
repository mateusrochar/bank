using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Conta
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double Entrada { get; set; }
        public double Saida { get; set; }

        public Conta(int iD, string nome, double saldo)
        {
            ID = iD;
            Nome = nome;
            Saldo = saldo;
        }

        public Conta()
        {
        }

        public double Deposito (double entrada)
        {
            return Saldo += entrada;
        }

        public double Saque (double saque)
        {
            return Saldo -= saque;
        }





    }
}
