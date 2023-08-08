using System.Runtime.InteropServices;

namespace array__lists_and_colections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nomes = new List<string> { "<nome>", "Ana", "Felipe" };

            nomes.Add("Diogo");
            nomes.Add("Maria");

            nomes.Remove("Ana");

            nomes.RemoveAt(0); //Utiliza o index para remover
            nomes.Add("Wesley");
            nomes.Add("Alex");

            nomes.Sort(); //ordenacao padrao por ordem alfabetica

            foreach (var nome in nomes)
            {
                Console.WriteLine($"Olá {nome.ToUpper()}!");
            }

            Console.WriteLine($"Este nome: {nomes[1]} está na posicao 1");

            //posicao é o index
            var index = nomes.IndexOf("Maria");
            if (index == -1)
            {
                Console.WriteLine($"Quando o item nao for encontrado, IndexOf retornará {index}");
            }
            else
            {
                Console.WriteLine($"O nome {nomes[index]} está na posicao {index}");

            }

            List<int> ilista = new List<int> { 1, 5, 6, 7 };

            //Sequencia Fibonacci
            var numeroFibo = new List<int> { 1, 1 };
            
            while(numeroFibo.Count <= 30)
            {
                var numeroAnterior1 = numeroFibo[numeroFibo.Count - 1];
                var numeroAnterior2 = numeroFibo[numeroFibo.Count - 2];

                var item = numeroAnterior1 + numeroAnterior2;
                numeroFibo.Add(item);

                Console.WriteLine(item);
            }

            Console.WriteLine("Finalizado o processo.");



        }
    }
}