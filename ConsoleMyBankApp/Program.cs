using System;

namespace ConsoleMyBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Larissa Sampaio", "000.000.000-00", "Desenvolvedora");

            ContaCorrente conta = new ContaCorrente();

            conta.titular = cliente;
            conta.agencia = 01;
            conta.conta = 0001;

            Console.WriteLine("Titular: {0}", conta.titular.nome);
            Console.WriteLine("Agência: {0}", conta.agencia);
            Console.WriteLine("Conta Corrente: {0}", conta.conta);
        }
    }
}
