namespace Repetition_programmering_Annette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width=Console.WindowWidth;

            //Opgave 1
            int age = 25;
            double height = 1.75;
            double weight = 70.5;
            char initial= 'A';
            string name = "Alice";
            bool isStudent = true;

            Console.WriteLine($"Age: {age} \nHeight: {height} \nWeight: {weight} \nInitial: {initial} \nName: {name} \nIs student: {isStudent}");

            Console.ReadLine();

            //Opgave 2
            //Fra Celsius til Fahrenheit
            Console.WriteLine(new string('-', width));
            Console.WriteLine("Omregning mellem Celsius og Fahrenheit");
            Console.WriteLine($"Indtast grader Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double calculatedFahrenheit = (celsius * 9 / 5) + 32;

            //Fra Fahrenheit til Celsius
            Console.WriteLine($"Indtast grader Fahrenheit: ");
            double fahrenheit=Convert.ToDouble(Console.ReadLine());
            double calculatedCelsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"\n{celsius}°C is {calculatedFahrenheit}°F \n{fahrenheit}°F is {calculatedCelsius}°C");
            Console.ReadLine() ;

            //Opgave 3
            Console.WriteLine(new string('-', width));
            Console.WriteLine("\nIndtast højde (meter): ");
            double højde=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nIndtast vægt (kg): ");
            double vægt=Convert.ToDouble(Console.ReadLine());
            double bmi = vægt / (højde*højde);
            Console.WriteLine($"BMI: {bmi}");
            Console.ReadLine() ;

            //Opgave 4
            Console.WriteLine(new string('-', width));
            Console.WriteLine($"Brug af + - * / og %");
            int sum = 5 + 10;
            int difference = 15 - 10;
            int product = 5 * 10;
            int quotient = 10 / 5;
            int remainder = 10 % 5;
            Console.WriteLine($"\nSum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}, Remainder: {remainder}");
            Console.ReadLine();

            //Opgave 5
            Console.WriteLine(new string('-', width));
            Console.WriteLine($"Beregning af areal og omkreds af en cirkel");
            Console.WriteLine("\nIndtast radius på cirklen: ");
            double radius=Convert.ToDouble(Console.ReadLine());
            double omkreds=2*radius*double.Pi;
            double areal=radius*radius*double.Pi;
            Console.WriteLine($"\nOmkreds af cirklen: {omkreds}\nAreal af cirklen: {areal}");
            Console.ReadLine();

            //Opgave 6
            Console.WriteLine(new string('-', width));
            Console.WriteLine("Brug af logiske og sammenligningsoperatører til at evaluere udtryk");
            Console.WriteLine("\nIndtast det første heltal: ");
            int førsteTal=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIndtast det andet heltal: ");
            int andetTal = Convert.ToInt32(Console.ReadLine());

            bool isEqual=(førsteTal==andetTal);
            bool isNotEqual=(førsteTal!=andetTal);
            bool isGreater=(førsteTal>andetTal);
            bool isLess=(førsteTal<andetTal);
            bool isGreaterOrEqual=(førsteTal>=andetTal);
            bool isLessOrEqual=(førsteTal<=andetTal);

            Console.WriteLine($"\nIs Equal: {isEqual}, Is not equal: {isNotEqual}, Is greater: {isGreater}, Is less: {isLess}, Is greater or equal: {isGreaterOrEqual}, Is less or equal: {isLessOrEqual}");
            Console.ReadLine();


        }
    }
}
