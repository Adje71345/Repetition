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
        }

        
    }

}





