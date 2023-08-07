namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Interpolacao
            //string primeiroAmigo = "Joao";
            //string segundoAmigo = "Maria";

            //Console.WriteLine($"Meus amigos sao {primeiroAmigo} e {segundoAmigo}");

            //Console.WriteLine($"o nome {primeiroAmigo} tem {primeiroAmigo.Length} letras");
            //Console.WriteLine($"o nome {segundoAmigo} tem {segundoAmigo.Length} letras");


            ////Remover espacos
            //string saudacao = "         Olá Mundo!      ";
            //Console.WriteLine($"[{saudacao}]");

            //string apararSaudacao = saudacao.TrimStart();
            //Console.WriteLine($"[{apararSaudacao}]");

            //apararSaudacao = saudacao.TrimEnd();
            //Console.WriteLine($"[{apararSaudacao}]");

            //apararSaudacao = saudacao.Trim();
            //Console.WriteLine($"[{apararSaudacao}]");


            ////Replace, ToUpper and ToLower
            //string digaOla = "Olá Mundo!";
            //Console.WriteLine(digaOla);

            //digaOla = digaOla.Replace("Olá", "eaE");
            //Console.WriteLine(digaOla);

            //Console.WriteLine(digaOla.ToUpper());
            //Console.WriteLine(digaOla.ToLower());


            ////Pesquisas
            //string letraMusica = "Voce disse tchau, e eu digo olá";
            //Console.WriteLine(letraMusica.Contains("tchau"));
            //Console.WriteLine(letraMusica.Contains("saudacoes"));

            //Console.WriteLine(letraMusica.StartsWith("Voce"));
            //Console.WriteLine(letraMusica.StartsWith("tchau"));

            //Console.WriteLine(letraMusica.EndsWith("olá"));
            //Console.WriteLine(letraMusica.EndsWith("tchau"));

            //Console.WriteLine(letraMusica.IndexOf("tchau"));

        }
    }
}