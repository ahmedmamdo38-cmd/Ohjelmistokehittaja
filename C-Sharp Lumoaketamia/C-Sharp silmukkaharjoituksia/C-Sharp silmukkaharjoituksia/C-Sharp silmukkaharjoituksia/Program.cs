namespace C_Sharp_silmukkaharjoituksia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tehtävä1();
        }

        static void Tehtävä1()
        {
            int lainaRaha = 5000;
            int lainaAika = 2;
            double korko = 0.02;
            double korkosumma = 0;
            double maksettava = 0;
            maksettava = lainaRaha;
            for (int i = 0; i < lainaAika; i++)
            {
                maksettava += maksettava * korko;
            }
            korkosumma = maksettava - lainaRaha;
            maksettava = lainaRaha + korkosumma;
            Console.WriteLine("Maksettavaa tulee {0} + {1} = {2}", lainaRaha, korkosumma, maksettava);

            Console.ReadKey();
        }

        static void Tehtävä2()
        {
            int kertoma = 1;
            Console.WriteLine("Anna luku, josta lasketaan kertoma: ");
            int luku = int.Parse(Console.ReadLine());
            for (int i = 1; i <= luku; i++)
            {
                kertoma *= i;
            }
            Console.WriteLine("Luvun {0} kertoma on {1}", luku, kertoma);
            Console.ReadKey();
        }

        static void Tehtävä3()
        {
            int[] taulukko = new int[] { 6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3 };
            foreach(int i in taulukko)
            {
                if (taulukko = 0; )
            }
        }
    }

}
