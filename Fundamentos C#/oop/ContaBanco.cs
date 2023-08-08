using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class ContaBanco
    {
        public string Numero { get; }
        public string Dono { get; set; }
        public decimal Saldo 
        {
            get
            {
                decimal saldo = 0;
                foreach (var item in todasTransacoes)
                {
                    saldo += item.Valor;
                }
                return saldo;
            }
        }

        public static int numeroConta = 1234567890;

        private List<Transacao> todasTransacoes = new List<Transacao>();


        public ContaBanco(string nome, decimal valor)
        {
            this.Dono = nome;
            numeroConta++;

            this.Numero = numeroConta.ToString();

            Depositar(valor, DateTime.Now, "Saldo Inicial");
        }

        public void Depositar(decimal valor, DateTime data, string obs)
        {
            if (valor <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "Nao aceitamos deposito de valor 0 ou negativo.");
            }

            Transacao trans = new Transacao(valor, data, obs);
            todasTransacoes.Add(trans);
        }

        public void Sacar(decimal valor, DateTime data, string obs)
        {
            if (valor <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "Nao aceitamos saque de valor 0 ou negativo.");
            }
            if (Saldo - valor < 0)
            {
                throw new InvalidOperationException("Essa operacao nao é permitida");
            }

            Transacao trans = new Transacao(-valor, data, obs);
            todasTransacoes.Add(trans);
        }

        public string PegarMovimentacao()
        {
            var movimentacoes = new StringBuilder();

            movimentacoes.AppendLine("Data\t\t Valor\t Obs");

            foreach (var item in todasTransacoes)
            {
                movimentacoes.AppendLine($"{item.Data.ToShortDateString()}\t{item.Valor}\t{item.Obs}");

            }
            return movimentacoes.ToString();
        }

    }
}
