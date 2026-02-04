namespace if_else_harjoitukset
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
            //Tehtävä16();
            //Tehtävä17();
            Tehtävä18();
        }


        static void Tehtävä1()
        {
            Console.Write("Anna ensmmäinen luku: ");
            double luku1 = double.Parse(Console.ReadLine());

            Console.Write("\n Anna toinen luku: ");
            double luku2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Koska annoit kaksi lukua, ohjelma etsii näistä suurimman.");
            Console.WriteLine("Ja suurin luku on: ");

            if (luku1 > luku2)
            {
                Console.WriteLine("\n Ensimmäinen luku {0} on suurempi, kuin toinen luku {1}. ", luku1, luku2);
            }
            else if (luku2 > luku1)
            {
                Console.WriteLine("\n Toinen luku {0} on suurempi, kuin ensimmäinen luku {1}. ", luku2, luku1);
            }
            else
            {
                Console.WriteLine("\n Enssimmäien luku ja toinen luku on sama arvo.");
            }

            Console.ReadKey();
        }

        static void Tehtävä2()
        {
            Console.Write("Anna ensimmäinen luku: ");
            double luku1 = double.Parse(Console.ReadLine());

            Console.Write("Anna toinen luku: ");
            double luku2 = double.Parse(Console.ReadLine());

            Console.Write("Anna kolmas luku: ");
            double luku3 = double.Parse(Console.ReadLine());


            Console.WriteLine("\n Koska annoit kolme lukua, ohjelma etsii näistä suurimman.");

            if (luku1 > luku2 && luku1 > luku3)
            {
                Console.WriteLine("\n {0} on suurempi, kuin {1} ja kuin {2}. ", luku1, luku2, luku3);

            }
            else if (luku2 > luku1 && luku2 > luku3)
            {
                Console.WriteLine("\n {0} on suurempi, kuin {1} ja kuin {2}. ", luku2, luku1, luku3);

            }
            else
            {
                Console.WriteLine("\n {0} on suurempi, kuin {1} ja kuin {2}. ", luku3, luku2, luku1);

            }

            Console.ReadKey();
        }


        static void Tehtävä3()
        {
            Console.Write("Anna kokonaisluku: ");
            double luku = double.Parse(Console.ReadLine());


            if (luku > 0)
            {
                Console.WriteLine("\n Luku on positiivinen!!");
            }
            else if (luku < 0)
            {
                Console.WriteLine("\n Luku on negatiivinen!!");
            }
            else
            {
                Console.WriteLine("\n Luku on nolla!!");

            }

            Console.ReadKey();
        }

        static void Tehtävä4()
        {
            Console.Write("Anna luku: ");
            double luku = double.Parse(Console.ReadLine());

            if (luku % 5 == 0 || luku % 10 == 0)
            {
                Console.WriteLine("\n Luku on jaollinen 5: llä tai 11: llä.");
            }
            else
            {
                Console.WriteLine("\n Luku ei ole jaollinen 5: llä tai 11: llä.");
            }

            Console.ReadKey();
        }

        static void Tehtävä5()
        {
            Console.Write("Anna vuosi luku: ");
            double vuosi = double.Parse(Console.ReadLine());

            if (vuosi % 4 == 0 || vuosi % 100 == 0 || vuosi % 400 == 0)
            {
                Console.WriteLine(vuosi + "\n vuosi on karkausvuosi!! :)");
            }
            else
            {
                Console.WriteLine(vuosi + "\n vuosi ei ole karkausvuosi!! :( ");
            }

            Console.ReadKey();
        }


        static void Tehtävä6()
        {
            Console.Write("Anna kokonaisluku: ");
            double luku = double.Parse(Console.ReadLine());

            if (luku % 2 == 0)
            {
                Console.WriteLine("\n Luku on parillinen!!");
            }
            else
            {
                Console.WriteLine("\n Luku on pariton!!");
            }

            Console.ReadKey();

        }


        static void Tehtävä7()
        {
            Console.Write("Anna merkki: ");
            char merkki = Console.ReadKey().KeyChar;

            if (Char.IsLetter(merkki))
            {
                Console.WriteLine("\n Annettu merkki on kirjain!!");
            }
            else
            {
                Console.WriteLine("\n Annettu merkki ei ole kirjain!!");
            }

            Console.ReadKey();
        }

        static void Tehtävä8()
        {
            Console.Write("Anna kirjain: ");
            char vokaali = char.ToLower(Console.ReadKey().KeyChar);

            if (vokaali == 'a' || vokaali == 'e' || vokaali == 'o' || vokaali == 'u' || vokaali == 'y' || vokaali == 'ä' || vokaali == 'ö')
            {
                Console.WriteLine("\n Kirjain on vokaali!:)");
            }
            else
            {
                Console.WriteLine("\n Kirjain ei ole vokaali!:(");
            }

            Console.ReadKey();
        }


        static void Tehtävä9()
        {
            Console.Write("Anna merkki: ");
            char syotto = char.ToLower(Console.ReadKey().KeyChar);

            if (Char.IsLetter(syotto))
            {
                Console.WriteLine("\n Annettu merkki on kirjain.:)");

            }
            else if (Char.IsNumber(syotto))
            {
                Console.WriteLine("\n Annettu merkki on numero.:)");
            }
            else
            {
                Console.WriteLine("\n Annettu merkki on erikoismerkki.:)");
            }


            Console.ReadKey();
        }




        static void Tehtävä10()
        {
            Console.Write("Anna kirjain:");
            char kirjain = Console.ReadKey().KeyChar;

            if (Char.IsLower(kirjain))
            {
                Console.WriteLine("\n Annettu kirjain on iso kirjain.");
            }
            else if (Char.IsUpper(kirjain))
            {
                Console.WriteLine("\n Annettu kirjain on pieni kirjain.");
            }
            else
            {
                Console.WriteLine("\n Annettu merkki ei ole kirjain:(");
            }

            Console.ReadKey();
        }

        static void Tehtävä11()
        {
            Console.Write("Tässä ohjelmassa ohjelma laskee ostohinta ja myyntihinta, saitko voittoa vai tappiota.");
            Console.Write("\n Anna ostohinta:");
            double ostoHinta = double.Parse(Console.ReadLine());

            Console.Write("\n Anna myyntihinta:");
            double myyntiHinta = double.Parse(Console.ReadLine());

            if (myyntiHinta > ostoHinta)
            {
                double profit = myyntiHinta - ostoHinta;
                Console.WriteLine("Tulosta {0} voidaan tehdä.", profit);
            }
            else
            {
                Console.WriteLine("Voittoa ei voi saada.");
            }

            Console.ReadKey();
        }

        static void Tehtävä12()
        {

            List<string> tuntiList = new List<string>
            {
                "Englanti",
                "Fysikka",
                "Matikka",
                "Suomi",
                "Historia"
            };

            Console.WriteLine("Saatavilla olevat luokat:");
            for (int i = 0; i < tuntiList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tuntiList[i]}");
            }
            ;

            Console.WriteLine("\n Syöttä tuntin nimi:");
            string tuntiNimi = Console.ReadLine();

            if (tuntiList.Contains(tuntiNimi))
            {

                Console.Write("\n Syöttä sinun koe numerot (0-100):");
                int arvoSana = int.Parse(Console.ReadLine());


                if (arvoSana >= 90)
                {
                    Console.WriteLine($"\n Oneaa!! Läpäisit {tuntiNimi} arvosanalla {arvoSana} = K5 !!!");
                }
                else if (arvoSana >= 80)
                {
                    Console.WriteLine($"\n Oneaa!! Läpäisit {tuntiNimi} arvosanalla {arvoSana} = H4 !!!");
                }
                else if (arvoSana >= 70)
                {
                    Console.WriteLine($"\n Oneaa!! Läpäisit {tuntiNimi} arvosanalla {arvoSana} = H3!!!");
                }
                else if (arvoSana >= 60)
                {
                    Console.WriteLine($"\n Oneaa!! Läpäisit {tuntiNimi} arvosanalla {arvoSana} = T2 !!!");
                }
                else if (arvoSana >= 50)
                {
                    Console.WriteLine($"\n Oneaa!! Läpäisit {tuntiNimi} arvosanalla {arvoSana} = T1 !!!");
                }
                else
                {
                    Console.Write($"\n Epäonnistuit {tuntiNimi}. Arvosanasi oli {arvoSana}.");
                }
            }
            ;

            Console.ReadKey();
        }


        static void Tehtävä13()
        {
            Console.Write("Anna numero 1-7 ja ohjelma tulosta ne viikonpäiväksi: ");
            double viikonPäivät = double.Parse(Console.ReadLine());


            if (viikonPäivät == 1)
            {
                Console.WriteLine("\n Maanantai");
            }
            else if (viikonPäivät == 2)
            {
                Console.WriteLine("\n Tiistai");
            }
            else if (viikonPäivät == 3)
            {
                Console.WriteLine("\n Keskiviikko");
            }
            else if (viikonPäivät == 4)
            {
                Console.WriteLine("\n Torstai");
            }
            else if (viikonPäivät == 5)
            {
                Console.WriteLine("\n Perjantai");
            }
            else if (viikonPäivät == 6)
            {
                Console.WriteLine("\n Lauantai");
            }
            else if (viikonPäivät == 7)
            {
                Console.WriteLine("\n Suununtai");
            }
            else
            {
                Console.WriteLine("\n Syötti virhellinen!! Anna numero 1-7.");
            }


            Console.ReadKey();
        }

        static void Tehtävä14()
        {
            Console.Write("Anna kaksi kokonaisluku ja ohjelma tarkastaa onko ne ovat sama. ");

            Console.Write("\n Anna ensimmäinen kokonaisluku: ");
            double ensimmäinenKokonaisluku = double.Parse(Console.ReadLine());

            Console.Write("Anna toinen kokonaisluku: ");
            double toinenKokonaisluku = double.Parse(Console.ReadLine());

            if (ensimmäinenKokonaisluku == toinenKokonaisluku)
            {
                Console.WriteLine("Kaksi kokonaisluvut ovat sama.!");
            }
            else
            {
                Console.WriteLine("Virhe!! kaksi luvut ei ole sama.");
            }

            Console.ReadKey();
        }


        static void Tehtävä15()
        {
            Console.Write("Anna sinun ikä: ");
            int ikä = int.Parse(Console.ReadLine());

            if (ikä >= 18)
            {
                Console.WriteLine("Voit äänestä!!");
            }
            else
            {
                Console.WriteLine("Et voi äänestää, koska olet alle 18 vuotta.");
            }

            Console.ReadKey();
        }

        static void Tehtävä16()
        {
            Console.Write("Syöttä numero 1-12 välista ja ohejlma tulosta sen jälkeen paljonko kuukaudessa on päiviä:");
            int daysInMonth = int.Parse(Console.ReadLine());


            if (daysInMonth == 1)
            {
                Console.WriteLine("Syötä kuukausi: Tammikuu \n No. päiviä: 31 päivää");
            }
            else if (daysInMonth == 2)
            {
                Console.WriteLine("Syötä kuukausi: Helmikuu \n No. päiviä: 28 tai 29 päivää");
            }
            else if (daysInMonth == 3)
            {
                Console.WriteLine("Syötä kuukausi. Maaliskuu \n No. päiviä: 31 päivää");
            }
            else if (daysInMonth == 4)
            {
                Console.WriteLine("Syötä kuukausi: Huhtikuu \n No. päiviä: 30 päivää");
            }
            else if (daysInMonth == 5)
            {
                Console.WriteLine("Syötä kuukausi: Toukokuu \n No. päiviä: 31 päivää");
            }
            else if (daysInMonth == 6)
            {
                Console.WriteLine("Syötä kuukausi: Kesäkuuta \n No. päiviä: 30 päivää");
            }
            else if (daysInMonth == 7)
            {
                Console.WriteLine("Syötä kuukausi: Heinäkuu \n No. päiviä: 31 päivää");
            }
            else if (daysInMonth == 8)
            {
                Console.WriteLine("Syötä kuukausi: Elookuu \n No. päiviä: 31 päivää");
            }
            else if (daysInMonth == 9)
            {
                Console.WriteLine("Syötä kuukausi: Syyskuu \n No. päiviä: 30 päivää");
            }
            else if (daysInMonth == 10)
            {
                Console.WriteLine("Syötä kuukausi: Lokakuu \n No. päiviä: 31 päivää");
            }
            else if (daysInMonth == 11)
            {
                Console.WriteLine("Syötä kuukausi: Marraskuu \n No. päiviä: 30 päivää");
            }
            else if (daysInMonth == 12)
            {
                Console.WriteLine("Syötä kuukausi: Joulukuu \n No. päiviä: 31 päivää");
            }
            else
            {
                Console.WriteLine("Virhe!! Syötä numero 1-12");
            }

            Console.ReadKey();
        }

        static void Tehtävä17()
        {
            int amount;

            int note1, note2, note5, note10, note20, note50, note100, note500;

            note1 = note2 = note5 = note10 = note20 = note50 = note100 = note500 = 0;

            Console.WriteLine("Enter amount: ");
            amount = Convert.ToInt32(Console.ReadLine());

            if (amount >= 500)
            {
                note500 = amount / 500;
                amount -= note500 * 500;
            }
            if (amount >= 100)
            {
                note100 = amount / 100;
                amount -= note100 * 100;
            }
            if (amount >= 50)
            {
                note50 = amount / 50;
                amount -= note50 * 50;
            }
            if (amount >= 20)
            {
                note20 = amount / 20;
                amount -= note20 * 20;
            }
            if (amount >= 10)
            {
                note10 = amount / 10;
                amount -= note10 * 10;
            }
            if (amount >= 5)
            {
                note5 = amount / 5;
                amount -= note5 * 5;
            }
            if (amount >= 2)
            {
                note2 = amount / 2;
                amount -= note2 * 2;
            }
            if (amount >= 1)
            {
                note1 = amount;
            }

            Console.WriteLine("Total number of notes = \n");
            Console.WriteLine("500 = " + note500);
            Console.WriteLine("100 = " + note100);
            Console.WriteLine("50 = " + note50);
            Console.WriteLine("20 = " + note20);
            Console.WriteLine("10 = " + note10);
            Console.WriteLine("5 = " + note5);
            Console.WriteLine("2 = " + note2);
            Console.WriteLine("1 = " + note1);

            Console.ReadLine();

            Console.ReadKey();
        }


        static void Tehtävä18()
        {
            Console.Write("Tulo kolme kulmaa kolmio: ");
            int kulmaA = int.Parse(Console.ReadLine());
            int kulmaB = int.Parse(Console.ReadLine());
            int kulmaC = int.Parse(Console.ReadLine());

            int sum = kulmaA + kulmaB + kulmaC;

            if (sum == 180)
            {
                Console.WriteLine("Se on kelvollinen kolmio.\n ");
            }
            else
            {
                Console.WriteLine("Se on virheellinen kolmio. \n ");
            }

            Console.ReadKey();





            /*string[] koeNimit = { "Englanti", "Fysikka", "Matikka", "Suomi", "Historia" };
            koeNimit[0] = Console.ReadLine();
            koeNimit[1] = Console.ReadLine();
            koeNimit[2] = Console.ReadLine();
            koeNimit[3] = Console.ReadLine();
            koeNimit[4] = Console.ReadLine();

            if (koePistet >=  90)
            {
                Console.WriteLine("{0} arvosana on = K5", koeNimit[0]);
            }
            else if(koePistet >= 80)
            {
                Console.WriteLine("{0} arvosana on = H4", koeNimit[0]);
            }
            else if(koePistet >= 70)
            {
                Console.WriteLine("{0} arvosana on = H3", koeNimit[0]);
            }
            else if(koePistet >= 60)
            {
                Console.WriteLine("{0} arvosana on = T2", koeNimit[0]);
            }
            else if(koePistet >= 50)
            {
                Console.WriteLine("{0} arvosana on = T1", koeNimit[0]);
            }
            else
            {
                Console.WriteLine("{0} arvosana on = Hyllätty", koeNimit[0]);
            }


            if(koePistet >= 90)
            {
                Console.WriteLine("{1} arvosana on = K5", koeNimit[1]);
            }
            else if(koePistet >= 80)
            {
                Console.WriteLine("{1} arvosana on = H4", koeNimit[1]);
            }
            else if(koePistet >= 70)
            {
                Console.WriteLine("{1} arvosana on = H3", koeNimit[1]);
            }
            else if(koePistet >= 60)
            {
                Console.WriteLine("{1} arvosana on = T2", koeNimit[1]);
            }
            else if(koePistet >= 50)
            {
                Console.WriteLine("{1} arvosana on = T1", koeNimit[1]);
            }
            else
            {
                Console.WriteLine("{1} arvosana on = Hyllätty", koeNimit[1]);
            }


            if (koePistet >= 90)
            {
                Console.WriteLine("{2} arvosana on = K5", koeNimit[2]);
            }
            else if (koePistet >= 80)
            {
                Console.WriteLine("{2} arvosana on = H4", koeNimit[2]);
            }
            else if (koePistet >= 70)
            {
                Console.WriteLine("{2} arvosana on = H3", koeNimit[2]);
            }
            else if (koePistet >= 60)
            {
                Console.WriteLine("{2} arvosana on = T2", koeNimit[2]);
            }
            else if (koePistet >= 50)
            {
                Console.WriteLine("{2} arvosana on = T1", koeNimit[2]);
            }
            else
            {
                Console.WriteLine("{2} arvosana on = Hyllätty", koeNimit[2]);
            }



            if (koePistet >= 90)
            {
                Console.WriteLine("{3} arvosana on = K5", koeNimit[3]);
            }
            else if (koePistet >= 80)
            {
                Console.WriteLine("{3} arvosana on = H4", koeNimit[3]);
            }
            else if (koePistet >= 70)
            {
                Console.WriteLine("{3} arvosana on = H3", koeNimit[3]);
            }
            else if (koePistet >= 60)
            {
                Console.WriteLine("{3} arvosana on = T2", koeNimit[3]);
            }
            else if (koePistet >= 50)
            {
                Console.WriteLine("{3} arvosana on = T1", koeNimit[3]);
            }
            else
            {
                Console.WriteLine("{3} arvosana on = Hyllätty", koeNimit[3]);
            }


            if (koePistet >= 90)
            {
                Console.WriteLine("{4} arvosana on = K5", koeNimit[4]);
            }
            else if (koePistet >= 80)
            {
                Console.WriteLine("{4} arvosana on = H4", koeNimit[4]);
            }
            else if (koePistet >= 70)
            {
                Console.WriteLine("{4} arvosana on = H3", koeNimit[4]);
            }
            else if (koePistet >= 60)
            {
                Console.WriteLine("{4} arvosana on = T2", koeNimit[4]);
            }
            else if (koePistet >= 50)
            {
                Console.WriteLine("{4} arvosana on = T1", koeNimit[4]);
            }
            else
            {
                Console.WriteLine("{4} arvosana on = Hyllätty", koeNimit[4]);
            }}
            Console.ReadKey();*/
        }
    }
}
