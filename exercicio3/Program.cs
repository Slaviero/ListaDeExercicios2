using System.ComponentModel.Design;

namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite qualquer palavra: ");
            string entradaUsuario = Console.ReadLine();
            string fraseComCifra = "";
            char entradaCifraDeCesar;
            int cifraDeCesar = 2;
            
            for (int i = 0; i < entradaUsuario.Length; i++) 
            {
                entradaCifraDeCesar = entradaUsuario[i];

                if (char.IsLetter(entradaCifraDeCesar))
                { 
                    for (int j = 0; j < cifraDeCesar; j++)
                    { 
                        switch (entradaCifraDeCesar)
                        {
                            case 'z':
                                entradaCifraDeCesar = 'a';
                            break;

                            case 'Z':
                                entradaCifraDeCesar = 'A';
                            break;

                            default:
                                entradaCifraDeCesar++;
                            break;
                        }                    
                    }
                }

                fraseComCifra += entradaCifraDeCesar;
            }    
            Console.WriteLine($"Sua nova frase é:\n{fraseComCifra}");
        }
    }
}