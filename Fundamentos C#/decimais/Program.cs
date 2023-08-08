namespace decimais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double
            //double a = 5;
            //double b = 4;
            //double c = 2;
            //double d = (a + b) / c; ;
            //Console.WriteLine(d);

            //double f = 1.0 / 3.0;
            //Console.WriteLine(f);

            //decimais - maior precisao
            decimal c = 1.0M; //necessario usar o sufixo M
            decimal d = 3.0M;

            double raio = 2.50;
            double area = Math.PI * raio * raio;
            Console.WriteLine(area);

            //arredondamento
            Console.WriteLine(Math.Round(area, 5));





        }
    }
}