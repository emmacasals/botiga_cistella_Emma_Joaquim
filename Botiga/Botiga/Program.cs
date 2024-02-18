using System;
using System.IO;

namespace Botiga
{
    internal class Program
    {
        static string[] producte = new string[100];
        static double[] preus = new double[100];
        static int nEl = 0;

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
            return ($"\n----------------------------" +
                    $"\n1. Tenda" +
                    $"\n2. Cistella\n" +
                    $"\n0. Tancar programa" +
                    $"\n----------------------------" +
                    $"\n\nSeleccio: ");
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

        // TENDA

        static void AfegirProducte(ref string producte, ref double preu)
        {
            Console.Clear();
            Console.WriteLine("Indica quin producte vols afegir");
            producte = Console.ReadLine();
            Console.WriteLine("Indica quin preu té el producte que vols afegir");
            preu = Convert.ToDouble(Console.ReadLine());
            StreamWriter sw = new StreamWriter("Botiga.txt", append: true);
            sw.WriteLine(producte + "," + preu);
            sw.Close();
        }

        static void AfegirProducte(ref string[] producte, ref double[] preu, ref int nEl)
        {
            Console.Clear();
            StreamReader sr = new StreamReader("Botiga.txt");
            string line;
            int i = 0;
            while ((line = sr.ReadLine()) != null && i < producte.Length)
            {
                string[] parts = line.Split(',');
                producte[i] = parts[0];
                preu[i] = Convert.ToDouble(parts[1]);
                i++;
            }
            nEl = i;
            sr.Close();
        }

        static void AmpliarTenda(ref int num, ref string[] productes, ref double[] preus, ref int nEl)
        {
            Console.Clear();
            StreamReader sr = new StreamReader("Botiga.txt");
            nEl = 0;
            string seguiment = "";
            while (!sr.EndOfStream)
            {
                if (!sr.EndOfStream)
                {
                    seguiment.IndexOf(',');
                    nEl++;
                }
            }
            nEl++;
            //string[] aux = new string[productes.Length + num];
            //for (int i = 0;i++;)
            //   aux2[i] = productes[i];
            //   aux3[i] = preus[i];
            //productes = aux2;
        }

        static void ModificarPreu(string producte, double preu)
        {
            Console.Clear();
            StreamReader sr = new StreamReader("Botiga.txt");
            StreamWriter sw;
            string lectura = "";
            while (!sr.EndOfStream)
            {
                lectura = sr.ReadLine();
                if (lectura.Contains(producte))
                {
                    sw = new StreamWriter("Botiga2.txt");
                    Console.Write("Escriu el nou preu: ");
                    string noupreu = Console.ReadLine();
                    sw.WriteLine(producte + "," + noupreu);
                }
            }
            sr.Close();
        }

        static void ModificarProducte(string producteAntic, string producteNou)
        {
            Console.Clear();

        }

        static void OrdenarProducte(ref string[] producte, ref double[] preus)
        {
            Console.Clear();
            MostrarEnLinia(producte, preus);
            for (int i = 0; i < preus.Length - 1; i++)
            {
                if (producte[i].CompareTo(preus[i + 1]) == 0)
                    (producte[i], producte[i + 1]) = (producte[i + 1], producte[i]);
                (preus[i], preus[i + 1]) = (preus[i + 1], preus[i]);
            }
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
        static void MostrarEnLinia(string[] producte, double[] preus)
        {
            Console.Clear();

            for (int i = 0; i < preus.Length; i++)
                Console.WriteLine("Producte: {0}, Preu: {1}", producte[i], preus[i]);
        }

        static void OrdenarPreus(ref double[] preus)
        {
            Console.Clear();

        }

        static void Tenda()
        {
            Console.Clear();
            string num;
            Console.WriteLine("Escull que vols fer:" +
            "\n1. Mostrar productes" +
            "\n2. Afegir producte" +
            "\n3. Afegir producte" +
            "\n4. Ampliar tenda" +
            "\n5. Modificar preu" +
            "\n6. Modificar producte" +
            "\n7. Ordenar producte" +
            "\n8. Ordenar preu");
            num = Console.ReadLine();
            switch (num)
            {
                case "1":
                    Mostrar();
                    break;
                case "2":
                    AfegirProducte(ref producte[0], ref preus[0]);
                    break;
                case "3":
                    AfegirProducte(ref producte, ref preus, ref nEl);
                    break;
                case "4":
                    AmpliarTenda(ref nEl, ref producte, ref preus, ref nEl);
                    break;
                case "5":
                    ModificarPreu(producte[0], preus[0]);
                    break;
                case "6":
                    ModificarProducte(producte[0], producte[0]);
                    break;
                case "7":
                    OrdenarProducte(ref producte, ref preus);
                    break;
                case "8":
                    OrdenarPreus(ref preus);
                    break;
            }
        }

        static void Mostrar()
        {
            Console.Clear();
            StreamReader sr = new StreamReader(@"Botiga.txt");
            string productes;

            Console.WriteLine($"Botiga\n");
            while (!sr.EndOfStream)
            {
                productes = Format(sr.ReadLine());
                Console.Write(productes.Substring(0, productes.IndexOf("Preu:")));
                Console.SetCursorPosition(25, Console.CursorTop);
                Console.WriteLine(productes.Substring(productes.IndexOf("Preu:")));
            }
            sr.Close();
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

        static string ToString(int[] t, int n)
        {
            Console.Clear();
            string res = "Mostrar taula:\n";
            for (int i = 0; i < n; i++)
                res = res + "Taula[" + i + "] = " + t[i] + "\n";
            return res;
        }

        //CISTELLA
        static void ComprarProducte(string[] productes, int[] quantitats)
        {
            Console.Clear();
            Mostrar();
            Console.WriteLine("Escriu els productes que vols comprar");
          
        }

        static void ComprarProductes()
        {
            Console.Clear();

        }

        static void OrdenarCistella()
        {
            Console.Clear();

        }

        static void Cistella()
        {
            Console.Clear();
            string num;
            Console.WriteLine("Escull que vols fer:" +
            "\n1. Mostrar cistella" +
            "\n2. Comprar producte" +
            "\n3. Comprar productes" +
            "\n4. Ordenar cistella");
            num = Console.ReadLine();
            switch (num)
            {
                case "1":
                    Mostra();
                    break;
                case "2":
                    ComprarProducte();
                    break;
                case "3":
                    ComprarProductes();
                    break;
                case "4":
                    OrdenarCistella();
                    break;
            }
        }


        static void Cistella()
        {
            Console.Clear();
            string num;
            Console.WriteLine("Escull que vols fer:" +
            "\n1. Mostrar cistella" +
            "\n2. Comprar producte" +
            "\n3. Comprar productes" +
            "\n4. Ordenar cistella");
            num = Console.ReadLine();
            switch (num)
            {
                case "1":
                    Mostra();
                    break;
                case "2":
                    ComprarProducte();
                    break;
                case "3":
                    ComprarProductes();
                    break;
                case "4":
                    OrdenarCistella();
                    break;
            }
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
        }

        static string ToStringCistella(int[] t, int n)
        {
            Console.Clear();
            string res = "Mostrar cistella:\n";
            for (int i = 0; i < n; i++)
            {
                res += "Cistella[" + i + "] = " + t[i] + "\n";
            }
            return res;
        }

    }
}
