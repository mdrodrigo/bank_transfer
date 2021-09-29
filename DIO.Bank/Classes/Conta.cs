namespace DIO.Bank
{
    public class Conta
    {
        public Conta(TipoDeConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }
        private TipoDeConta TipoConta {get; set; }

        private double Saldo {get; set; }

        private double Credito {get; set; }

        private string Nome {get; set; }


    }
}