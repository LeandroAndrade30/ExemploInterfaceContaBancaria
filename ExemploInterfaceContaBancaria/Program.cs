using System;

namespace ExemploInterfaceContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do depósito da Conta Corrente:");
            double valorContaCorrente = double.Parse(Console.ReadLine());
            // Criação do objeto ContaCorrente c
            ContaCorrente c = new ContaCorrente();
            // chamada do método Depositar para a ContaCorrente c
            c.Depositar(valorContaCorrente);
            Console.WriteLine("Informe o valor do Saque:");
            double valorContaCorrenteSaque = double.Parse(Console.ReadLine());
            // chamada do método Sacar para a ContaCorrente c
            c.Sacar(valorContaCorrenteSaque);
            Console.WriteLine($"O saldo do valor da conta corrente é :{c.SaldoAtual}");
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Informe o valor do depósito da Conta Poupança:");
            double valorContaPoupanca = double.Parse(Console.ReadLine());
             
            // Criação do objeto ContaPoupanca p
            ContaPoupanca p = new ContaPoupanca();
            // chamada do método Depositar para a ContaPopupanca p
            // e sendo passado o valorContaPoupanca referente ao depósito
            p.Depositar(valorContaPoupanca);
            Console.WriteLine("Informe o valor do saque da Conta Poupança:");
            double valorSaqueContaPoupanca = double.Parse(Console.ReadLine());
            // chamada do método Scar para a ContaPoupanca p
            // passando o valorSaqueContaPoupanca
            p.Sacar(valorSaqueContaPoupanca);
            Console.WriteLine($"Seu saldo da conta poupança é: {p.Saldo}");







        }
    }
}
