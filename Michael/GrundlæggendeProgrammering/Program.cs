using System;


namespace GrundlæggendeProgrammering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.Opgave1();
            Program.Opgave2();
            Program.Opgave3();
            Program.Opgave4();
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
            Console.WriteLine($"{farenheit}°F is {(farenheit - 32) * ( 5.0 / 9 )}°C ");

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
            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = numbers.Sum();


            Console.WriteLine("Sum: " + sum + ", Difference:");
            
        }
    }
}
