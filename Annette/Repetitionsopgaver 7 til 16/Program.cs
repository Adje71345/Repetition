namespace Repetitionsopgaver_7_til_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = Console.WindowWidth;

            //Opgave 7
            Console.WriteLine("Program der tjekker, om et tal er positivt, negativt eller nul");
            Console.WriteLine("\nIndtast et tal: ");
            int indtastetTal=Convert.ToInt32(Console.ReadLine());
            if (indtastetTal > 0)
                Console.WriteLine("Tallet er positivt");
            else if (indtastetTal < 0)
                Console.WriteLine("Tallet er negativt");
            else
                Console.WriteLine("Tallet er 0");

            Console.ReadLine();

            //Opgave 8
            Console.WriteLine(new string('-', width));
            Console.WriteLine("\nIndtast en karakter (A, B, C, D, F): ");
            char karakter=Char.ToUpper(Console.ReadKey().KeyChar);

            if (ErBestået(karakter))
            {
                Console.WriteLine($"\nKarakteren {karakter} er bestået");
            }
            else if (karakter == 'F')
            {
                Console.WriteLine($"\nKarakteren {karakter} er ikke bestået");
            }
            else
            {
                Console.WriteLine("\nUgyldig karakter! Indtast kun A, B, C, D, F");
            }
            Console.ReadLine ();

            //Opgave 9
            Console.WriteLine(new string('-', width));
            Console.WriteLine("\nProgram, der tjekker om det er skudår.");
            Console.WriteLine("Indtast årstal: ");
            int årstal = Convert.ToInt32(Console.ReadLine());
            if (ErSkudår(årstal))
            {
                Console.WriteLine($"\nÅr {årstal} er et skudår");
            }
            else
            {
                Console.WriteLine($"\nÅr {årstal} er ikke et skudår");
            }
            Console.ReadLine();

            //Opgave 10
            Console.WriteLine(new string('-', width));
            Console.WriteLine("Program, der printer ugedag");
            Console.WriteLine("\n1: Mandag \n2: Tirsdag \n3: Onsdag \n4: Torsdag \n5: Fredag \n6: Lørdag \n7: Søndag \nIndtast et tal for ugedagen");
            int dag=Convert.ToInt32(Console.ReadLine());

            switch (dag)
            {
                case 1:
                    Console.WriteLine("\nDet er mandag");
                    break;
                case 2:
                    Console.WriteLine("\nDet er tirsdag");
                    break;
                case 3:
                    Console.WriteLine("\nDet er onsdag");
                    break;
                case 4:
                    Console.WriteLine("\nDet er torsdag");
                    break;
                case 5:
                    Console.WriteLine("\nDet er fredag");
                    break;
                case 6:
                    Console.WriteLine("\nDet er lørdag");
                    break;
                case 7:
                    Console.WriteLine("\nDet er søndag");
                    break;
                default:
                    Console.WriteLine("Ugyldigt tal! Indtast et tal mellem 1 og 7");
                    break;
            }
            Console.ReadLine();

            //Opgave 11

        }
        static bool ErBestået(char karakter)
        {
            return (karakter == 'A' || karakter=='B' || karakter=='C' || karakter=='D');
        }

        static bool ErSkudår(int årstal)
        {
            return (årstal % 4 == 0 && årstal % 100 !=0) || (årstal % 400 ==0);
        }
    }
}
