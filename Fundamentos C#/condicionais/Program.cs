namespace condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;

            if ((a + b > 10) && (a == b)) //as duas consicoes precisam ser true
            {
                Console.WriteLine("A resposta é maior do que 10.");
                Console.WriteLine("E o primeiro número é igual ao segundo.");
            }
            else
            {
                Console.WriteLine("A resposta é menor do que 10.");
                Console.WriteLine("E o primeiro número nao é igual ao segundo.");
            }

        }
    }
}