namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////while loop
            //int contador = 0;
            //while (contador <= 10)
            //{
            //    Console.WriteLine($"Olá mundo! O contador está em {contador}");
            //    contador++; 
            //}

            ////do while loop
            //int contador = 0;
            //do
            //{
            //    Console.WriteLine($"Olá mundo! O contador está em {contador}");
            //    contador++;
            //} while (contador < 10);

            //for loop
                //inicializador  //condicional  //incremento
            for(int contador = 0; contador < 10; contador ++)
            {
                Console.WriteLine($"Olá mundo! O contador está em {contador}");
            }

        }
    }
}