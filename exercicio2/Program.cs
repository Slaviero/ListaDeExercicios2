namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string fraseUsuario = Console.ReadLine();
            int contadorPalavras = fraseUsuario.Split(' ').Length;
            Console.WriteLine($"A sua frase contém {contadorPalavras} palavras.");
        }
    }
}