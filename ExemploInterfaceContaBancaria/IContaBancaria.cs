using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploInterfaceContaBancaria
{
     // criação da Interface IContaBancaria com
     // a declaração métodos depositar e Sacar
    public interface  IContaBancaria
    {
        void Depositar(double valor);
        void Sacar(double valor);
    }
}
