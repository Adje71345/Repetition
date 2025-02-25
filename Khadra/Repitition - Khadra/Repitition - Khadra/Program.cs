using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {
        // øvelse 1:
        Console.WriteLine("Øvelse 1");
        int age = 25;
        double height = 1.75;
        double weight = 70.5;
        char initial = 'A';
        string name = "Alice";
        bool IsStudent = true;

        Console.WriteLine($"Age:{age}, Height: {height}, Weight: {weight}, Initial {initial}, Name: {name}, Is student {IsStudent} ");

        // øvelse 2: 
  
            Console.WriteLine("Øvelse 2");

            double celsius = 25;
            double fahrenheit = celsius * (9.0 / 5.0) + 32.0;
            Console.WriteLine($"{celsius} C° er {fahrenheit} F°");

            fahrenheit = 77;
            celsius = (fahrenheit - 32) * (5.0 / 9.0);
            Console.WriteLine($"{fahrenheit}F° er {celsius}C°");

       // øvelse 3
            Console.WriteLine("Øvelse 3");
            
            double bmi = weight / Math.Pow(height,2);
            Console.WriteLine($"BMI: {bmi}");

        // øvelse 4
        Console.WriteLine("Øvelse 4");

        int x = 10;
        int y = 5;

        int sum = x + y;
        int diff = x - y;
        int product = x * y;
        int quot = x / y;
        int rem = x % y;

        Console.WriteLine($"Sum: {sum}, Difference: {diff}, Product: {product}, Quotient: {quot}, Remainder: {rem}");

        Console.WriteLine("Øvelse 5");
        double radius = 5.5;
        double diameter = 11.0;
        double areal = Math.PI * Math.Pow(radius,2);
        double omkreds = 2 * Math.PI * radius;
        Console.WriteLine($"Areal: {areal}, Omkreds: {omkreds}");

        Console.WriteLine("Øvelse 6");
        int k = 5;
        int h = 10;

        bool IsEqual = k == h;
        bool IsNotEqual = k != h;
        bool IsGreater = k > h;
        bool IsLess = k < h;
        bool IsGreaterOrEqual = k >= h;
        bool ISLessOrEqual = k <= h;

        Console.WriteLine($"Is equal: {IsEqual}, Is not equal: {IsNotEqual}, Is greater: {IsGreater}, Is less: {IsLess}, Is greater or equal: {IsGreaterOrEqual}, Is less or equal: {ISLessOrEqual} ");
        
        
        Console.ReadLine();


    }
}