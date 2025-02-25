using System;


namespace GrundlæggendeProgrammering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             Program.Opgave1();
             Program.Opgave2();
             Program.Opgave3();
             Program.Opgave4();
             Program.Opgave5();
             Program.Opgave6();
             Program.Opgave7();
             Program.Opgave8();
             Program.Opgave9();            
             Program.Opgave10();
             Program.Opgave11();
             Program.Opgave12();            
             Program.Opgave13();            
             Program.Opgave14();
             Program.Opgave15();
             Program.Opgave16();
             Program.Opgave17();
             Program.Opgave18();
             Program.Opgave19();
            */
            Program.Opgave20();
            
        }

        public static void Opgave1()
        {
            int age = 25;
            double height = 1.75;
            double weight = 70.5;
            Char initial = 'A';
            String name = "Alice";
            bool isStudent = true;

            Console.WriteLine($"Age: {age}, Height: {height}, Weight: {weight}, Initial: {initial}, Name: {name}, Is Student: {isStudent}");

        }
        public static void Opgave2()
        {
            int farenheit = 77;
            int celsious = 25;

            Console.WriteLine($"{celsious}°C is {celsious * (9.0 / 5) + 32}°F ");
            Console.WriteLine($"{farenheit}°F is {(farenheit - 32) * (5.0 / 9)}°C ");

        }


        public static void Opgave3()
        {
            double højde = 1.75;
            double vægt = 70;

            //Math.Pow(x, y) Beregner 2^3
            Console.WriteLine($"Din BMI er: {vægt / Math.Pow(højde, 2)}");
        }
        public static void Opgave4()
        {
            int[] numbers = { 5, 10 };

            int sum = numbers.Sum();
            int difference = numbers.Max() - numbers.Min();
            int product = numbers.Aggregate(1, (acc, n) => acc * n);
            int quotient = numbers.Max() / numbers.Min();
            int remainder = numbers.Max() % numbers.Min();

            Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}, Remainder: {remainder}");
        }

        public static void Opgave5()
        {
            Console.Write("Indtast radius af cirklen: ");

            // Læs radius fra brugeren og konverter til double
            if (double.TryParse(Console.ReadLine(), out double radius) && radius > 0)
            {
                // Beregn areal og omkreds
                double area = Math.PI * Math.Pow(radius, 2);
                double circumference = 2 * Math.PI * radius;

                // Udskriv resultatet
                Console.WriteLine($"Area: {area}, Circumference: {circumference}");
            }
            else
            {
                Console.WriteLine("Ugyldig input. Indtast venligst et positivt tal.");
            }

        }

        public static void Opgave6()
        {
            int a = 10;
            int b = 20;

            // Sammenligningsoperatorer
            bool isEqual = (a == b);
            bool isNotEqual = (a != b);
            bool isGreater = (a > b);
            bool isLess = (a < b);
            bool isGreaterOrEqual = (a >= b);
            bool isLessOrEqual = (a <= b);

            // Udskriv resultatet
            Console.WriteLine($"Is Equal: {isEqual}, Is Not Equal: {isNotEqual}, Is Greater: {isGreater}, Is Less: {isLess}, Is Greater Or Equal: {isGreaterOrEqual}, Is Less Or Equal: {isLessOrEqual}");
        }
        public static void Opgave7()
        {

            // Bruger indtaster et tal
            Console.Write("Indtast et tal: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Tjekker om tallet er positivt, negativt eller nul
            if (number > 0)
            {
                Console.WriteLine("Tallet er positivt.");
            }
            else if (number < 0)
            {
                Console.WriteLine("Tallet er negativt.");
            }
            else
            {
                Console.WriteLine("Tallet er nul.");
            }
        }


        public static void Opgave8()
        {
            Console.WriteLine("Indtast din karakter (A, B, C, D, F): ");

            char[] karakterIndex = { 'A', 'B', 'C', 'D', 'F' }; // Mulige karakterer
            string karakterInput = Console.ReadLine().ToUpper(); // Læser input og gør det stort

            // Sikrer at der er mindst ét tegn i input
            if (string.IsNullOrWhiteSpace(karakterInput) || karakterInput.Length != 1)
            {
                Console.WriteLine("Ugyldigt input. Indtast kun ét bogstav.");
                return; // Stopper metoden, hvis input er ugyldigt
            }

            char karakter = karakterInput[0]; // Henter første tegn fra input

            if (karakter == 'A' || karakter == 'B' || karakter == 'C' || karakter == 'D')
            {
                Console.WriteLine("Du bestod!");
            }
            else if (karakter == 'F')
            {
                Console.WriteLine("Du dumpede.");
            }
            else
            {
                Console.WriteLine("Ugyldigt input. Indtast kun A, B, C, D eller F.");
            }

            Console.ReadLine(); // Holder konsollen åben
        }

        public static void Opgave9() 
        {
                // Bruger indtaster et tal
                Console.Write("Indtast et tal: ");
                int number = Convert.ToInt32(Console.ReadLine());

                // Tjekker om tallet er positivt, negativt eller nul
                if (number > 0)
                {
                    Console.WriteLine("Tallet er positivt.");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Tallet er negativt.");
                }
                else
                {
                    Console.WriteLine("Tallet er nul.");
                }

                // Bruger indtaster et år
                Console.Write("Indtast et årstal: ");
                int year = Convert.ToInt32(Console.ReadLine());

                // Tjekker om året er et skudår
                if (ErSkudår(year))
                {
                    Console.WriteLine($"{year} er et skudår.");
                }
                else
                {
                    Console.WriteLine($"{year} er IKKE et skudår.");
                }
            }

            // Metode der tjekker om et år er et skudår
            static bool ErSkudår(int år)
            {
                // Et år er skudår hvis det er deleligt med 4, men IKKE deleligt med 100, 
                // medmindre det også er deleligt med 400.
                return (år % 4 == 0 && år % 100 != 0) || (år % 400 == 0);
            }

        public static void Opgave10()
        {
            string[] ugeDage = { "Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fredag" };

            Console.WriteLine("Skriv et tal (1-5) for at få ugedagen:");

            if (int.TryParse(Console.ReadLine(), out int userChoice) && userChoice >= 1 && userChoice <= 5)
            {
                Console.WriteLine($"Dagen er: {ugeDage[userChoice - 1]}"); // -1 da arrays starter fra 0
            }
            else
            {
                Console.WriteLine("Ugyldigt input. Indtast et tal mellem 1 og 5.");
            }
        }

        public static void Opgave11() 
        {
            Console.Write("Indtast et tal mellem 1 og 12 for at få information om måneden: ");

            if (int.TryParse(Console.ReadLine(), out int month) && month >= 1 && month <= 12)
            {
                string[] months = {
                "Januar: Årets første måned, ofte kold og med sne i mange lande.",
                "Februar: Den korteste måned, kendt for fastelavn og valentinsdag.",
                "Marts: Forårets komme begynder så småt.",
                "April: Kendt for påske og omskifteligt vejr.",
                "Maj: Foråret er i fuld gang, og naturen blomstrer.",
                "Juni: Sommerens begyndelse, ofte med varmt vejr og lange dage.",
                "Juli: Højsommer, mange holder ferie.",
                "August: Stadig sommer, men dagene begynder at blive kortere.",
                "September: Efterårets begyndelse, bladene begynder at skifte farve.",
                "Oktober: Efteråret er i fuld gang, og det kan være blæsende og regnfuldt.",
                "November: En mørk og ofte trist måned.",
                "December: Årets sidste måned, kendt for jul og nytår."
            };

                Console.WriteLine(months[month - 1]);
            }
            else
            {
                Console.WriteLine("Ugyldigt input. Indtast et tal mellem 1 og 12.");
            }
        }
        public static void Opgave12()
        {   
            //En løkker der kører fra 1 til 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Opgave13()
        {
            int i = 1;
            
            while (i < 11)
            {
                Console.WriteLine(i);
                i++;
            }

        }
        public static void Opgave14()
        {
            int number = 1;
            do
            {
                Console.Write($"{number}\n");
                number++;
            } while (number <= 11);
            Console.ReadKey();

        }
        public static void Opgave15()
        {
            Console.Write("Indtast et tal: ");
            int n;

            // Sikrer at brugeren indtaster et gyldigt tal
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
            {
                Console.Write("Ugyldigt input. Indtast et positivt heltal: ");
            }

            int sum = 0;

            // For-løkke til at beregne summen af tallene fra 1 til n
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Summen af de første {n} tal er: {sum}");
        }
        public static void Opgave16()
        {
            Console.Write("Indtast et tal for at beregne fakultet: ");
            int n;

            // Sikrer at brugeren indtaster et gyldigt tal
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.Write("Ugyldigt input. Indtast et positivt heltal eller 0: ");
            }

            long factorial = 1;

            // Beregner fakultet ved hjælp af en for-løkke
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Fakultetet af {n} er: {factorial}");

        }
        public static void Opgave17()
        {
            Console.Write("Indtast det første tal: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast det andet tal: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            // Kald metoden for at beregne summen
            int resultat = BeregnSum(tal1, tal2);

            Console.WriteLine($"Summen af {tal1} og {tal2} er: {resultat}");
        }

        // Metode til at returnere summen af to heltal
        static int BeregnSum(int a, int b)
        {
            return a + b;
        }
        public static void Opgave18()
        {
            Console.Write("Indtast en tekst: ");
            string input = Console.ReadLine();

            // Kald metoden for at vende strengen om
            string omvendtTekst = VendStringOm(input);

            Console.WriteLine($"Omvendt tekst: {omvendtTekst}");
        }

        // Metode til at vende en streng om
        static string VendStringOm(string tekst)
        {
            char[] charArray = tekst.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static void Opgave19()
        {
            Console.Write("Indtast en tekst: ");
            string input = Console.ReadLine();

            // Kald metoden til at tælle vokaler
            int antalVokaler = TælVokaler(input);

            Console.WriteLine($"Antal vokaler i teksten: {antalVokaler}");
        }

        // Metode til at tælle vokaler i en streng
        static int TælVokaler(string tekst)
        {
            // Definer de danske vokaler
            char[] vokaler = { 'a', 'e', 'i', 'o', 'u', 'y', 'æ', 'ø', 'å' };
            int count = 0;

            // Gå igennem hvert tegn i strengen
            foreach (char c in tekst.ToLower()) // Konverter til små bogstaver for at undgå fejl
            {
                if (Array.Exists(vokaler, v => v == c)) // Tjek om tegnet er en vokal
                {
                    count++;
                }
            }

            return count;
        }
        public static void Opgave20()
        {
            // Beregning af firkantens areal
            Console.Write("Indtast firkantens bredde: ");
            double bredde = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast firkantens højde: ");
            double højde = Convert.ToDouble(Console.ReadLine());

            double firkantAreal = BeregnAreal(bredde, højde);
            Console.WriteLine($"Arealet af firkanten er: {firkantAreal}");

            // Beregning af cirklens areal
            Console.Write("Indtast radius af cirklen: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double cirkelAreal = BeregnAreal(radius);
            Console.WriteLine($"Arealet af cirklen er: {cirkelAreal}");
        }

        // Overloadet metode til firkant (rektangel)
        static double BeregnAreal(double bredde, double højde)
        {
            return bredde * højde;
        }

        // Overloadet metode til cirkel
        static double BeregnAreal(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
