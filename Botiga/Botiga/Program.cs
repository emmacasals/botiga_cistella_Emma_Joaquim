namespace Botiga
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
        //TENDA
        static void AfegirProducte(string producte, double preu)
        {  
            Console.WriteLine("Indica quin producte vols afegir");
            producte = Console.ReadLine();
            Console.WriteLine("Indica quin preu té el producte que vols afegir");
            preu=Convert.ToInt32(Console.ReadLine);

        }
        static void AfegirProducte(string[] producte, double[] preu)
        {
            
        }
        static void AmpliarTenda(int num, string[] productes, double[] preus, double[] preu)
        {
            string[] aux = new string[productes.Length + num];
            for (int i = 0;i++;)
               aux2[i] = productes[i];
               aux3[i] = preus[i];
            productes = aux2;
        }
        static void ModificarPreu(string producte, double preu)
        {

        }
        static void ModificarProducte(string producteAntic, string producteNou)
        {

        }
        static void OrdenarProducte(string[] producte, double[] preus)
        {
            MostrarEnLinia(producte, preus);
            for (int numVolta = 0; numVolta < preus - 1; numVolta++)
                if producte[i].CompareTo(preus[numVolta]) == 0
                    (producte[i], producte[i + 1]) = (producte[int + 1], producte[i]);
                    (preus[i], preus[i + 1]) = (preus[int + 1], preus[i]);
        }

        //ampliacio de concepte
        /*
         * main
         * int[]array={1,2,3,4};
         * metode(array);
         * array [1]?
         * 
         * he passat una array que fas un pas per valor pero com es un array actua com a fals pas per referencia
         * metode (int [] t)----->        si nomes vols modificar valor
        t[1]=5;
        int auz={10,9,8,7,6,5,4,3};
        t=aux;
        en el de ampliar array ficar aixi  metode (ref int [] t)-->aixo nomes quan el array original acabi dapuntar
        a un altre espai de memoria fer servir ref

         */
        static void MostrarEnLinia(int[] producte, int[] preus)
        {

            for (int i = 0;i < preus ; i++)
                Console.Write( "{0}",preus[i]);
            Console.WriteLine();
        }
        static void OrdenarPreus()
        {
            
        }
        static void Mostrar()
        {
            StreamReader sr = new StreamReader(@"Botiga.txt");
            string productes;
            Console.WriteLine($"Botiga\n");
            while ( sr.EndOfStream)
            {
                productes = Format(sr.ReadLine());
                Console.Write(productes.Substring(0, productes.IndexOf("Preu:")));
                Console.SetCursorPosition(25, Console.CursorTop);
                Console.WriteLine(productes.Substring(productes.IndexOf("Preu:")));
            }
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
        static string ToString( int[] t, int n)
        {
            string res = "Mostrar taula:\n";
            for (int i = 0; i < n; i++)
                res= res + "Taula[" + i + "] = " + t[i] + "\n";
                 return res;
        }
        //CISTELLA
        static void ComprarProducte(string producte, int quantitat, string[] producteBotiga, double[] preus)
        {
            producteBotiga = Mostrar();
        }
        static void ComprarProducte(string[] productes, int[] quantitats)
        {

        }
        static void OrdenarCistella()
        {


        }
        static void Mostra()
        {

        }
        static void ToStringCistella()
        {
            string res = "Mostrar taula:\n";
            for (int i = 0; i < n; i++)
                res = res + "Taula[" + i + "] = " + t[i] + "\n";
            return res;
        }
    }
}
