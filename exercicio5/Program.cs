namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string fraseUsuario = Console.ReadLine();
            string[] separadorDePalavras = fraseUsuario.Split(' ');
            Console.WriteLine($"Frase em letras maiúsculas: {fraseUsuario.ToUpper()}");
            Console.WriteLine($"Frase em letras minúsculas: {fraseUsuario.ToLower()}");
            Console.WriteLine($"Quantidade de caracteres da frase: {fraseUsuario.Length}");
            Console.WriteLine($"Primeira palavra da frase: {separadorDePalavras[0]} ");
            Console.WriteLine($"Última palavra da frase: {separadorDePalavras[separadorDePalavras.Length-1]}");
        }
    }
}


//Imprimir a frase em letras maiúsculas;
//Imprimir a frase em letras minúsculas;
//Imprimir a quantidade de caracteres da frase;
//Imprimir a primeira palavra da frase;
//Imprimir a última palavra da frase.
