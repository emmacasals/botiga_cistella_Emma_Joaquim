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
                    Tenda();
                    break;
                case '2':
                    Cistella();
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
            StreamReader sr = new StreamReader("Cistella.txt");
            Console.WriteLine("La teva sistella actual és: ");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            sr.Close();
            return;
        }
        static void Cistella()
        {
            Console.Clear();
            char num;
            Console.WriteLine("Escull que vols fer:" +
            "\n1. Mostrar cistella" +
            "\n2. Comprar producte" +
            "\n3. Comprar productes" +
            "\n4. Ordenar cistella");
            num = Console.ReadKey().KeyChar;
            switch (num)
            {
                case '1':
                    Mostra();
                    break;
                //case '2':
                //    ComprarProducte();
                //    break;
                //case '3':
                //    ComprarProducte();
                //    break;
                //case '4':
                //    OrdenarCistella();
                //    break;
            }
        }
        static void Tenda()
        {
            Console.Clear();
            char num;
            Console.WriteLine("Escull que vols fer:" +
            "\n1. Mostrar productes" +
            "\n2. Afegir producte" +
            "\n3. Afegir producte" +
            "\n4. Ampliar tenda" +
            "\n5. Modificar preu" +
            "\n6. Modificar producte" +
            "\n7. Ordenar producte" +
            "\n8. Ordenar preu");
            num = Console.ReadKey().KeyChar;
            switch (num)
            {
                case '1':
                    Mostrar();
                    break;
                //case '2':
                //    AfegirProducte(ref nEl);
                //    break;
                //case '3':
                //    AfegirProducte();
                //    break;
                //case '4':
                //    AmpliarTenda(ref nEl);
                //    break;
                //case '5':
                //    ModificarPreu();
                //    break;
                //case '6':
                //    ModificarProducte();
                //    break;
                //case '7':
                //    OrdenarProducte();
                //    break;
                //case '8':
                //    OrdenarPreus();
                //    break;
            }
        }
    }
}
