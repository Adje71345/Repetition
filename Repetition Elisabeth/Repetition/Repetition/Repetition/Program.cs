namespace Repetition
{
    internal class Program
    {
        static void Main()
        {


            int age = 26;
            double height = 1.80;
            double weight = 80.8;
            char initial = 'E';
            string name = "Erik";
            bool isStudent = true;
            double eksponent = 2;
            double bmi = weight / (Math.Pow(height, eksponent));

            Console.WriteLine($"{name} (initial: {initial}) er {age} år gammel, vejer {weight} kilogram og er {height} meter høj. Er de studerende: {isStudent}");

            Console.WriteLine($"Deres BMI er {bmi}");

            CelsiusToFahrenheit();
        }
        static void CelsiusToFahrenheit()
        {

            while (true)
            {
                Console.WriteLine("Vil du konvertere fra Celsius til Fahrenheit eller fra Fahrenheit til Celsius?\n" +
                    "1. Celsius to Fahrenheit\n" +
                    "2. Fahrenheit to Celsius\n" +
                    "3. Videre til næste");
                string choice = Console.ReadLine() ?? "";
                if (choice == "1")
                {
                    Console.WriteLine("Indtast grader i Celsius:");
                    double celsius = double.Parse(Console.ReadLine() ?? "");
                    double fahrenheit = celsius * 9 / 5 + 32;
                    Console.WriteLine($"{celsius} grader Celsius er {fahrenheit} grader Fahrenheit");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Indtast grader i Fahrenheit:");
                    double fahrenheit = double.Parse(Console.ReadLine() ?? "");
                    double celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"{fahrenheit} grader Fahrenheit er {celsius} grader Celsius");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Udregning af cirkels areal og omkreds:");
                    break;
                }
            }
            CircleCalculator();
        }
        static void CircleCalculator()
        {
            Console.WriteLine("Hvad vil du udregne?\n" +
                "1. Arealet af en cirkel" +
                "\n2. Omkreds af en cirkel" +
                "\n3. Videre til næste");
            string choice = Console.ReadLine() ?? "";


            while (true)

            {
                switch (choice)
                {
                    case "1":
                        {
                            Console.WriteLine("Indtast cirklens radius:");
                            double radius = double.Parse(Console.ReadLine() ?? "");
                            double areal = Math.PI * Math.Pow(radius, 2);
                            Console.WriteLine($"Arealet af cirklen er {areal}");
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Indtast cirklens radius:");
                            double radius = double.Parse(Console.ReadLine() ?? "");
                            double omkreds = 2 * Math.PI * radius;
                            Console.WriteLine($"Omkredsen af cirklen er {omkreds}");
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Logiske operatører:");
                            LogiskeOperatører();
                            break;
                        }

                }
            }



        }
        static void LogiskeOperatører()
        {
            Console.WriteLine("Indtast et tal:");
            int tal = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Indtast et andet tal:");
            int tal2 = int.Parse(Console.ReadLine() ?? "");
            bool erDetStørre = tal > tal2;
            bool erDetMindre = tal < tal2;
            bool erDeLige = tal == tal2;
            bool erDeForskellige = tal != tal2;
            bool erDetStørreEllerLige = tal >= tal2;
            bool erDetMindreEllerLige = tal <= tal2;
            Console.WriteLine($"{tal} er større end {tal2}: {erDetStørre}\n{tal} er mindre end {tal2}: {erDetMindre}\n{tal} er lige med {tal2}\n{tal} er forskellig fra {tal2}: {erDeForskellige}");
            Console.WriteLine("Nu til mere sjov med tal:");
            PositivtEllerNegativt();

        }

        static void PositivtEllerNegativt()
        {
            Console.WriteLine("Indtast er tal:");
            int pntal = int.Parse(Console.ReadLine() ?? "");
            if (pntal > 0)
            {
                Console.WriteLine("Tallet er positivt");
            }
            else if (pntal < 0)
            {
                Console.WriteLine("Tallet er negativt");
            }
            else
            {
                Console.WriteLine("Tallet er 0");
            }

            Console.WriteLine("Videre til næste:");
            BeståetEllerEj();

        }




        static void BeståetEllerEj()
        {
            Console.WriteLine("Bestod du? Indtast karakter (amerikansk system) for at tjekke:");
            char karakter = char.Parse(Console.ReadLine() ?? "");
            if (karakter == 'A' || karakter == 'B' || karakter == 'C')
            {
                Console.WriteLine("Du har bestået!");
            }
            else if (karakter == 'F')
            {
                Console.WriteLine("Du bestod sgu ikke.");
            }
            else if (karakter == 'D')
            {
                Console.WriteLine("Lige med nød og næppe!");
            }

            Ugedag();
        }


        static void Ugedag()
        {
            Console.WriteLine("Indtast et tal mellem 1 og 7:");
            int dag = int.Parse(Console.ReadLine() ?? "");
            switch (dag)
            {
                case 1:
                    Console.WriteLine("Mandag");
                    break;
                case 2:
                    Console.WriteLine("Tirsdag");
                    break;
                case 3:
                    Console.WriteLine("Onsdag");
                    break;
                case 4:
                    Console.WriteLine("Torsdag");
                    break;
                case 5:
                    Console.WriteLine("Fredag");
                    break;
                case 6:
                    Console.WriteLine("Lørdag");
                    break;
                case 7:
                    Console.WriteLine("Søndag");
                    break;
                default:
                    Console.WriteLine("Ugyldigt input");
                    break;
            }


            Måned();
        }

        static void Måned()
        {
            Console.WriteLine("Hvilken måned vil du vide mere om? Indtast tallet:\nTryk 13 for at gå videre");
            int måned = int.Parse(Console.ReadLine() ?? "");
            switch (måned)
            {
                case 1:
                    Console.WriteLine("Lortemåned, men hvis du er heldig, får du sne.");
                    break;
                case 2:
                    Console.WriteLine("OK måned, 4/10");
                    break;
                case 3:
                    Console.WriteLine("Denne måned bliver det varmere og det er sgu lækkert og TILTRÆNGT!!");
                    break;
                case 4:
                    Console.WriteLine("du er grim. APRILSNAR!!");
                    break; 
                case 5:
                    Console.WriteLine("awwww y-månend");
                    break;
                case 6:
                    Console.WriteLine("nu har vi snart sommerferie jubiii");
                    break;
                case 7:
                    Console.WriteLine("SOMMERFERIE!!!");
                    break;
                case 8:
                    Console.WriteLine("ej nu slutter den:(");
                    break;
                case 9:
                    Console.WriteLine("uhh stadig hyggeligt, farverne peaker:D");
                    break;
                case 10:
                    Console.WriteLine("liiidt koldt, men farverne og den klare luft gør op for det!:D");
                    break;
                case 11:
                    Console.WriteLine("Afsked - Lars HUG");
                    break;
                case 12:
                    Console.WriteLine("jesu b-month");
                    break;
                case 13:
                    Tal110();
                    break;
            }
        }

        

    static void Tal110()
        {
            for (int i = 1; i <= 10; i++) 
                Console.WriteLine(i.ToString());
            TalWhile();
        }
        static void TalWhile()
        {
            int k = 0;
            while (10 > k)
           
            {
                k++;
                Console.WriteLine(k.ToString());
            }
        }
    }
}




