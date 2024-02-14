namespace Botiga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch entre botiga o cistella
            string num = "0";
            switch (num)
            {
                case "1":
                    Mostrar();
                    break;
                case "2":
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
        static void OrdenarProducte(string producte, double[] preus)
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
        static void  MostrarEnLinia(int[] producte, int[] preus)
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
            switch ()
            {
                default:
                    break;
            }
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
