using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploInterfaceContaBancaria
{
      // Criação da classe Conta Corrente utilizando a interface 
      // IContaBancaria
    public class ContaCorrente : IContaBancaria
    {
        // Criação do atributo Saldo
        private double Saldo;

        // Criação do Construtor ContaCorrente
        public ContaCorrente()
        {
            Saldo = 0;  // inicializando o atributo Saldo


        }

        // criasa a propridade Publica SaldoAtual que retorna o Saldo
        public double SaldoAtual
        {
            get { return Saldo; }
        }

        // Implementando o método Depositar
        public void Depositar(double valor)
        {
            Saldo = Saldo + valor;
        }


        // Implementando o método Sacar
        public void Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo = Saldo - valor;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
            }


        }
    }
}

