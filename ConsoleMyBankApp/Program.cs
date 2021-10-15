using System;

namespace ConsoleMyBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Larissa Sampaio", "000.000.000-00", "Desenvolvedora");

            ContaCorrente conta = new ContaCorrente(cliente, 01, 0001);


            Console.WriteLine("Conta Corrente Criada");
            Console.WriteLine("Titular: {0}", conta.getTitular().getNome());
            Console.WriteLine("Agência: {0}", conta.getAgencia());
            Console.WriteLine("Conta Corrente: {0}", conta.getConta());

            Console.WriteLine("Parabéns! Seu saldo é de R${0}, obrigada por criar sua conta!", conta.getSaldo());

            double valorDeposito = 500;
            conta.Depositar(valorDeposito);
            
            Console.WriteLine("Seu saldo é de R${0}.", conta.getSaldo());

            double valorSaque = 100;
            conta.Sacar(valorSaque);

            Console.WriteLine("Seu saldo é de R${0}.", conta.getSaldo());
            
            Cliente clienteSilvia = new Cliente("Tiago Ávila", "000.000.000-00", "Estudante");

            ContaCorrente contaSilvia = new ContaCorrente(clienteSilvia, 01, 0002);

            double valorPix = 500;
            conta.Pix(valorPix, contaSilvia);

            Console.WriteLine("Seu saldo é de R${0}.", conta.getSaldo());
            Console.WriteLine("Seu saldo é de R${0}.", contaSilvia.getSaldo());


        }
    }
}
