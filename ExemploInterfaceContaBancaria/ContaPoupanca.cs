using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploInterfaceContaBancaria
{
    // Criação da Classe ContaPoupanca
    // Utilizando a interface IContaBancaria
    public class ContaPoupanca : IContaBancaria
    {
        // Criação do Atributo privado _saldo 
        private double _saldo;

        // Criação da propridade Sado que retorna o atributo _saldo privado
        public double Saldo
        {
            get { return _saldo; }
        }

        // Implementação do método DEpositar
        public void Depositar(double valor)
        {
            _saldo = _saldo + valor;
        }


        // Implementação do método Sacar
        public void Sacar(double valor)
        {
            if (_saldo >= valor)
            {
                _saldo = _saldo - valor;
            }
        }
    }
}
