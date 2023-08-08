namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            oop.ContaBanco contaB = new ContaBanco("Diogo", 10000);
            Console.WriteLine($"A conta {contaB.Numero} de {contaB.Dono} foi criada com {contaB.Saldo}");

            contaB.Sacar(800, DateTime.Now, "Fiz as compras");
            Console.WriteLine($"A conta está com {contaB.Saldo}");
            try
            {
                contaB.Depositar(0, DateTime.Now, "Recebi um pagamento");
                Console.WriteLine($"A conta está com {contaB.Saldo}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Operacao nao realizada");
            }

            contaB.Sacar(1500, DateTime.Now, "Pagar o aluguel");

            contaB.Sacar(2000, DateTime.Now, "Pagar a escola das criacas");

            Console.WriteLine(contaB.PegarMovimentacao());
        }
    }
}