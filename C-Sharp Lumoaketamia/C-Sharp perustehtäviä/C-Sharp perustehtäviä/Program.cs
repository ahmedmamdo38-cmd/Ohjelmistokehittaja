using System.Diagnostics;
using System.Formats.Asn1;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace C_Sharp_perustehtäviä
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tehtävä1();
            //Tehtävä2();
            //Tehtävä3();
            //Tehtävä4();
            //Tehtävä5();
            //Tehtävä6();
            //Tehtävä7();
            //Tehtävä8();
            //Tehtävä9();
            //Tehtävä10();
            //Tehtävä11();
            //Tehtävä12();
            //Tehtävä13();
            //Tehtävä14();
            //Tehtävä15();
            Tehtävä17();
        }

        static void Tehtävä1()
        {
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }

        static void Tehtävä2()
        {
            Console.WriteLine("Syötä ensimmäinen luku: ");
            double luku1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Syötä toinen luku: ");
            double luku2 = double.Parse(Console.ReadLine());

            double summa = luku1 + luku2;

            Console.WriteLine($"Lukujen {luku1} ja  {luku2} summa on = {summa}  " );
            Console.ReadKey();
        }

        static void Tehtävä3()
        {
            Console.WriteLine("Syötä ensimmäinen luku: ");
            double luku1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Syötä toinen luku: ");
            double luku2 = double.Parse(Console.ReadLine());

            double summa = luku1 - luku2;
            Console.WriteLine($"Lukujen {luku1} ja {luku2} summa on = {summa} ");
            Console.ReadKey();
        }

        static void Tehtävä4()
        {
            Console.WriteLine("Syötä ensimmäinen luku: ");
            double luku1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Syötä toinen luku: ");
            double luku2 = double.Parse(Console.ReadLine());

            double summa = luku1 * luku2;
            Console.WriteLine($"Lukujen {luku1} ja {luku2} summa on = {summa} ");
            Console.ReadKey();
        }

        static void Tehtävä5()
        {
            Console.WriteLine("Syötä ensimmäinen luku. ");
            double luku1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Syötä toinen luku: ");
            double luku2 = double.Parse(Console.ReadLine());

            double summa = luku1 / luku2;

            Console.WriteLine($"Lukujen {luku1} ja {luku2} tulos = {summa} ");
            Console.ReadKey();
        }

        static void Tehtävä6()
        {
            Console.WriteLine("Syötä lämpötila Celsius-asteina: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"{celsius} C vastaa {fahrenheit} F ");
            Console.ReadKey();

        }

        static void Tehtävä7()
        {
            Console.WriteLine("Syötä lämpötila Celsius-asteina: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"{fahrenheit} F vastaa {celsius} C");
            Console.ReadKey();
        }

        static void Tehtävä8()
        {
            Console.WriteLine("Syötä luku.Muunta mailit kilometriksi. ");
            double mailit = double.Parse(Console.ReadLine());

            double km = mailit * 1.60934;

            Console.WriteLine($"{mailit} mailia on {km} kilometriä ");
            Console.ReadKey();
        }

        static void Tehtävä9()
        {
            Console.WriteLine("Syötä luku.Muunta kilometriä mailiksi. ");
            double km = double.Parse(Console.ReadLine());

            double mailit = km / 1.60934;

            Console.WriteLine($"{km} kilometriä on {mailit} mailia.");
            Console.ReadKey();
        }

        static void Tehtävä10()
        {
            Console.WriteLine("Syötä luku.Muunta tuumat senteiksi.");
            double tuumat = double.Parse(Console.ReadLine());

            double sentit = tuumat * 2.54;

            Console.WriteLine($"{tuumat} tuumia on {sentit} sentiä.");
            Console.ReadKey();
        }

        static void Tehtävä11()
        {

            Console.WriteLine("Syötä luku.Muunta sentit tuumaksi.");
            double sentit = double.Parse(Console.ReadLine());

            double tuumat = sentit / 2.54;

            Console.WriteLine($"{sentit} sentiä on {tuumat} tuumia.");
            Console.ReadKey();
        }

        static void Tehtävä12()
        {
            Console.WriteLine("Syötä luku.Muunta yardit metreiksi");
            double yardit = double.Parse(Console.ReadLine());

            double metrit = yardit * 0.9144;

            Console.Write($"{yardit} yardia on {metrit} metria.");
            Console.ReadKey();
        }

        static void Tehtävä13()
        {
            Console.WriteLine("Syötä luku.Muunta metrit yardiksi.");
            double metrit = double.Parse(Console.ReadLine());


            double yardit = metrit / 1.09361;

            Console.WriteLine($"{metrit} metria on {yardit} yardia.");
            Console.ReadKey();
        }

        static void Tehtävä14()
        {

            Console.WriteLine("Syötä ensimmäinen luku (a): ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Syötä toinen luku (a): ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("\nValitse laskutoimitus: ");
            Console.WriteLine("1. Yhteenlasku (a + b ).");
            Console.WriteLine("2. Minuslasku ( a - b ).");
            Console.WriteLine("3. Kertolasku (a * b ). ");
            Console.WriteLine("4. Jakolasku ( a / b ). ");

            Console.WriteLine("Anna numero 1-4.");
            int valinta = int.Parse(Console.ReadLine());

            switch (valinta)
            {
                case 1:
                    Console.WriteLine("\n Yhteenlasku: {0} + {1} = {2}",a,b, (a+b));
                    break;
                case 2:
                    Console.WriteLine("\n Minuslasku: {0} - {1} = {2}",a,b, (a-b));
                    break;
                case 3:
                    Console.WriteLine("\n Kertolasku:  {0} * {1} = {2}",a,b, (a*b));
                    break;
                case 4:
                    Console.WriteLine("\n Jakolasku:  {0} / {1} = {2}",a,b, (a/b));
                    break;
                default:
                    Console.WriteLine("\nVirheellinen valinta! Valitse numero väliltä 1-4.");
                    break;
            }
            Console.ReadKey();
        }


        static void Tehtävä15()
        {
            Console.WriteLine("Syötä ympyrän säde: ");
            double sade = double.Parse(Console.ReadLine());

            if(sade >= 0)
            {
                double pintaAla = Math.PI * Math.Pow(sade, 2);

                Console.WriteLine($"Ympyrän pinta-ala säteellä {sade} on {pintaAla:F2}");

            }
            else
            {
                Console.WriteLine("Virhe: Säde ei voi olla negattivinen! ");

            }

            Console.ReadKey();
        }

        static void Tehtävä16()
        {
            Console.WriteLine("Syötä neliön sivun mitta. ");
            double sivu = double.Parse(Console.ReadLine());


            if(sivu >= 0)
            {
                //(A = sivu * sivu)
                double pintaAla = Math.Pow(sivu, 2);

                Console.WriteLine($"Neliön pinta-ala mitalla {sivu} on {pintaAla:F2}");

            }
            else
            {
                Console.WriteLine("Virhe: Sivun mitta ei voi olla negatiivinen!");
            }

            Console.ReadKey();
        }

        static void Tehtävä17()
        {
            Console.WriteLine("Syötä suorakulmion pituus: ");
            double pituus = double.Parse(Console.ReadLine());

            Console.WriteLine("Syötä suorakulmion leveys: ");
            double leveys = double.Parse(Console.ReadLine());

            if(pituus >= 0 &&  leveys >= 0)
            {
                double pintaAla = pituus * leveys;
                Console.WriteLine($"Suorakulmion pinta-ala pituudella {pituus} ja leveydellä {leveys} on {pintaAla:F2} cm");
            }
            else
            {
                Console.WriteLine("Virhe: Pituus ja leveys ei voi olla negattivinen!!!");
            }

            Console.ReadKey();

        }


        static void Tehtävä18()
        {
            //I skip this task for later :)
        }
    }
}
