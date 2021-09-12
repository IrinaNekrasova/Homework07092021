using System;

namespace Homework0709
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kā tevi sauc?");
            string userAnswer = Console.ReadLine();
            Console.WriteLine("Sveiks, " + userAnswer + "!");
            
            Console.WriteLine("                                        ");
           
            Console.WriteLine("Kāds ir tavs vecums?");
            string userAgeText = Console.ReadLine();
            int userAge = int.Parse(userAgeText);
            int fullAge = userAge +1;
            Console.WriteLine("Nākamgad tev paliks " + fullAge + "!");
           
            Console.WriteLine("                                        ");
            
            Console.WriteLine("Uzspēlēsim! Šoreiz uzminēšu, kurš skaitlis ir lielāks");
            Console.WriteLine("Ievadi pirmo skaitli");
            string userNumber1 = Console.ReadLine();
            Console.WriteLine("Ievadi otro skaitli");
            string userNumber2 = Console.ReadLine();
            int maxNumber1 = int.Parse(userNumber1);
            int maxNumber2 = int.Parse(userNumber2);
            int maxLargest = Math.Max(maxNumber1, maxNumber2);
            Console.WriteLine("Lielākais tevis ievadītais skaitlis ir " +maxLargest);

            Console.WriteLine("                                        ");

            Console.WriteLine("Uzspēlēsim vēlreiz! Uzminēšu, kurš skaitlis ir mazāks");
            Console.WriteLine("Ievadi pirmo skaitli");
            string userNumber3 = Console.ReadLine();
            Console.WriteLine("Ievadi otro skaitli");
            string userNumber4 = Console.ReadLine();
            int minNumber3 = int.Parse(userNumber3);
            int minNumber4 = int.Parse(userNumber4);
            int minSmalest= Math.Min(minNumber3, minNumber4);
            Console.WriteLine("Mazākais tevis ievadītais skaitlis ir " + minSmalest);

            Console.WriteLine("                                        ");


            Console.WriteLine("Pārbaudīsim dalījumus");
            Console.WriteLine("Ievadi dalāmo skaitli");
            string userNumber5 = Console.ReadLine();
            Console.WriteLine("Ievadi dalītāju");
            string userNumber6 = Console.ReadLine();
            int Number5 = int.Parse(userNumber5);
            int Number6 = int.Parse(userNumber6);
            double numSum1 = Number5 %= Number6;
            Console.WriteLine("Šoreiz dalījuma atlikums ir " + numSum1);

            Console.WriteLine("                                        ");


            Console.WriteLine("Taisnstūra laukums!");
            Console.WriteLine("Ievadi vienas malas garumu");
            string userNumber7 = Console.ReadLine();
            Console.WriteLine("Ievadi otras malas garumu");
            string userNumber8 = Console.ReadLine();
            double Number7 = int.Parse(userNumber7);
            double Number8 = int.Parse(userNumber8);
            double numSum2 = Number7 * Number8;
            double rounded = Math.Round(numSum2, 2);
            Console.WriteLine("Šoreiz taisnstūra laukums ir " + numSum2);


            Console.WriteLine("                                        ");
            Console.WriteLine("Vienādsānu trijstūra laukums!");
            Console.WriteLine("Ievadi malas garumu");
            string userNumber9 = Console.ReadLine();
            double Number9 = int.Parse(userNumber9);
            double formula = Math.Sqrt(3)/4;
            double area = formula * Number9 * Number9;
            Console.WriteLine("Šoreiz trijstūra laukums ir " + area);


            Console.WriteLine("                                        ");


            string interpolatedText = $"Sveiks vēlreiz! Tavi sauc {userAnswer}! Tavs vecums ir {userAge} un nākamgad tev būs {fullAge}! Atā!!!";
            Console.WriteLine(interpolatedText);




        }
    }
}
