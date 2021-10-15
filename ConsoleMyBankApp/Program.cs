using System;

namespace ConsoleMyBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.nome = "Larissa Sampaio";
            cliente.cpf = "000.000.000-00";
            cliente.profissao = "Desenvolvedora";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = cliente;
            conta.agencia = 01;
            conta.conta = 0001;

            Console.WriteLine("Titular: {0}", conta.titular);
            Console.WriteLine("Agência: {0}", conta.agencia);
            Console.WriteLine("Conta Corrente: {0}", conta.conta);
        }
    }
}
