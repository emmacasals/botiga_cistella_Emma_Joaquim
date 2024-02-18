namespace Proves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcio = 'a';
            while (opcio != '0')
            {
                do
                {
                    Console.Clear();
                    Console.Write(Menu());
                    opcio = Console.ReadKey().KeyChar;
                }
                while (!(opcio == '1' || opcio == '2' || opcio == '0'));
                Escollir(opcio);
            }
        }
        static string Menu()
        {
            string text;
            text = ($"\n----------------------------" +
                $"\n1. Tenda" +
                $"\n2. Cistella" +
                $"\n" +
                $"\n0. Tencar programa" +
                $"\n----------------------------" +
                $"\n\nSeleccio: ");
            return text;
        }
        static void Escollir(char num)
        {
            switch (num)
            {
                case '1':
                    Mostrar();
                    break;
                case '2':
                    Mostra();
                    break;
            }
        }
        static void Mostrar()
        {
            Console.Clear();
            StreamReader sr = new StreamReader("Botiga.txt");
            string productes;
            Console.WriteLine("Botiga:\n");
            while (!sr.EndOfStream)
            {
                productes = Format(sr.ReadLine());
                Console.Write(productes);
            }
            sr.Close();
            return;
        }
        static string Format(string productes)
        {
            int i = 0;
            string producte, preu;
            producte = productes.Substring(0, productes.IndexOf(','));
            productes = productes.Substring(productes.IndexOf(',') + 1);
            preu = productes.Substring(0, productes.IndexOf(','));
            return $"Producte: {producte} Preu: {preu}€";
        }
        static void Mostra()
        {
            Console.Clear();
            Console.WriteLine("bye");
            return;
        }
    }
}
