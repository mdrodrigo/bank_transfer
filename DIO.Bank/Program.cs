using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoDeConta.PessoaFisica,10,10,"Esferico");

            Console.WriteLine("Hello World!");
        }
    }
}
