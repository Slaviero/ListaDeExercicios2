using System.Globalization;

namespace ListaDeExercicios2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var textinfo = new CultureInfo("pt-BR", false).TextInfo;
            Console.WriteLine("Digite uma frase:");
            string fraseUsuario = textinfo.ToTitleCase(Console.ReadLine());
            Console.WriteLine(fraseUsuario);

        }
    }
}