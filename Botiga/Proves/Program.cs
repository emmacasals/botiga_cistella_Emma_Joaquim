namespace Proves
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string num = "0";
            Console.WriteLine($"\n----------------------------" +
                $"\n1. Tenda" +
                $"\n2. Cistella" +
                $"\n----------------------------");
            Console.Write("Seleccio: ");
            num = Console.ReadLine();
            //switch entre botiga o cistella
            
            switch (num)
            {
                case "1":
                    Mostrar();
                    break;
                case "2":
                    Mostra();
                    break;
                default:
                    Console.WriteLine("Aixo no és una opcio valida.");
                    break;
            }
        }
        static void Mostrar()
        {
            Console.WriteLine("hello");
        }
        static void Mostra()
        {
            Console.WriteLine("bye");
        }
    }
}
