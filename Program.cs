namespace Måndag_20._2
{
    using System;
    using System.Numerics;
    using System.Threading.Channels;


    internal class Program
    {
        static void Main(string[] args)
        {
            static void reset()
            {
                Console.ResetColor();
                Console.Write(new string('\n', 3));
                Main(null);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Måndags övningar D11-ovn-1");
            Console.WriteLine("Heltal, flyttal, booleska värden");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("Välj ett övningsnummer:");
            Console.WriteLine("1. Fyra uttryck");
            Console.WriteLine("2. Två uttryck");
            Console.WriteLine("3. Byta inehåll i variabler");
            Console.WriteLine("4. SumQuad - Summan av alla kvadrater");
            Console.WriteLine("5. Factorial");
            Console.WriteLine("6. Samma som nr. 5");
            Console.WriteLine("7. Foor-loop");
            Console.WriteLine("8. Kvadratroten");
            Console.WriteLine("9. Kubikroten");
            Console.WriteLine("10. Kvadratrötterna och kubikroten ");
            Console.WriteLine("11. Tria + IsEven + ");
            Console.WriteLine("44. Primtal 1-10");
            Console.WriteLine("99. Avsluta");

            int val = Int32.Parse(Console.ReadLine());
            switch (val)
            {
                case 1:

                    ovning1();
                    break;
                case 2:
                    ovning2();
                    break;
                case 3:
                    ovning3();
                    break;
                case 4:
                    ovning4();
                    break;
                case 5:
                    ovning5();
                    break;
                case 6:
                    ovning6();
                    break;
                case 7:
                    ovning7();
                    break;
                case 8:
                    ovning8();
                    break;
                case 9:
                    ovning9();
                    break;
                case 10:
                    ovning10();
                    break;
                case 11:
                    ovning11();
                    break;
                case 44:
                    ovning44();
                    break;
                case 99:
                    Console.WriteLine("Tack för mig.");
                    break;
                default:
                    Console.WriteLine("Ogiltigt val. Välj ett nummer mellan 1 och 10.");
                    break;

            }

            static void ovning1()
            {
                int sum1 = -1 + 4 * 6;
                int sum2 = (35 + 5) % 7;
                int sum3 = 14 + (-4 * 6 / 11);
                int sum4 = 2 + 15 / 6 * 1 - 7 % 2;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Summan -1 + 4*6= " + sum1);
                Console.WriteLine("Summan (35 + 5)%7= " + sum2);
                Console.WriteLine("Summan 14 + -4*6/11= " + sum3);
                Console.WriteLine("Summan 2 + 15/6*1 – 7%2= " + sum4);
                reset();
            }
            static void ovning2()
            {
                double sum1 = 14.0 + -4.0 * 6.0 / 11.0;
                double sum2 = 2.0 + 15.0 / 6.0 * 1.0 - 7.0 % 2.0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Summan från 14.0 + -4.0 * 6.0 / 11.0;" + " = " + sum1);
                Console.WriteLine("Summan från 2.0 + 15.0 / 6.0 * 1.0 – 7.0%2.0" + " = " + sum2);
                reset();

            }
            static void ovning3()
            {





                Console.Write("Mata in s1: ");
                string s1 = Console.ReadLine();
                Console.Write("Mata in s2: ");
                string s2 = Console.ReadLine();
                //...hemlig programkod här...
                s1 = s1 + s2;
                s2 = s1.Substring(0, s1.Length - s2.Length);
                s1 = s1.Substring(s2.Length);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("s1 = " + s1);
                Console.WriteLine("s2 = " + s2);
                Console.ForegroundColor = ConsoleColor.Green;


                reset();




            }
            static void ovning4()
            {
                /*  Skriv ett program som skriver ut resultatet av följande uttryck(förväntat output till höger):
                  false && false  False
                  false || true   True
                  false && true   False
                     ! false      True            */
                Console.WriteLine(false && false); // False
                Console.WriteLine(false || true);  // True
                Console.WriteLine(false && true);  // False
                Console.WriteLine(!false);        // True
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                reset();




            }
            static void ovning5()
            {

                double d = 3 / 2.0;


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("3 / 2.0 = " + $"d = {d}");
                reset();


            }
            static void ovning6()
            {
                int i = (int)(13.12 / 1.5);
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"i = {i}");


                reset();
            }
            static void ovning7()
            {
                Console.WriteLine("Ange ett heltal: ");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                if (tal1 == 2 || tal1 >= 5)
                { Console.WriteLine("Ok"); }

                else
                {
                    Console.WriteLine("Fel!");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();


                reset();
            }
            static void ovning8()
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                reset();

            }
            static void ovning9()
            {
                int s = 0, prod = 1;
                s = s + 1;
                do
                {
                    s = s + 1;
                    prod = prod * s;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"s = {s}, prod = {prod}");
                }
                while (s < 10);


                reset();
            }
            static void ovning10()
            {
                for (int i = 1; i < 12; i++)
                {
                    double C = Cube(i);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Cube{i} = {C}");

                }
                reset();

            }
            static void ovning11()
            {
                for (int i = 1; i < 13; i++)
                {
                    double C = Tria(i);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Cube{i} = {C} " + isEven(C) + "    " + IsPrime(Convert.ToInt32(C)));

                }
                reset();
            }
            static void ovning44()
            {
                for (int i = 1; i < 18; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Tal {i}  {IsPrime(i)}");
                }
                reset();
            }
            static bool isEven(double n)
            {

                return n % 2 == 0;
            }
            static double Tria(double v)
            {
                return (v * v + v) / 2.0;
            }

            static double Cube(double x)
            {
                return x * x * x;
            }

            static string IsPrime(int p)
            {
                for (int i = 2; i < p; i++)
                    if (p % i == 0)
                        return "Sammansatt";
                return "Primtal";


            }

        }



    }
}
