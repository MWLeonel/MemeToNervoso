using System;

namespace MemeToNervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            string nervoso;

            //<---Inicio(Digite)--->//
            Console.WriteLine("Usuário, o que você pensa sobre mim? ");
            nervoso = Console.ReadLine();
            Console.Write("\n");
            //<---Fim(Digite)--->//

            //<---Inicio(Nervoso)--->//
            Console.WriteLine(" -E sabe o que eu penso de você?");
            Console.WriteLine($"{nervoso.Remove(10)} ... NÃO, PERA.\nTo nervoso");
            //<---Fim(Nervoso)--->//

            //<---Inicio(Sair)--->//
            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadKey();
            //<---Fim(Sair)--->//
        }
    }
}
