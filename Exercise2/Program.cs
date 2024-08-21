using System.Security.Principal;

namespace Exercise2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int principal = 0; //declares and initializes principal variable
            double rate = 0; //declares and initializes rate variable
            int time = 0; //declares and initializes time variable
            int intrest = 0; //declares and initializes intrest variable

            Console.WriteLine("What is the pricipal amount of the loan in dollars?"); //prompt the user for imput
            principal = Convert.ToInt32(Console.ReadLine()); //user imputs amount of loan and converts it to a int

            Console.WriteLine("What is the intrest rate (input 0.05 for 5%)?"); //prompt the user for imput
            rate = Convert.ToDouble(Console.ReadLine()); //user imputs amount of intrest rate and converts it to a double

            Console.WriteLine("What is period of loan in years?"); //prompt the user for imput
            time = Convert.ToInt32(Console.ReadLine()); //user imputs amount of loan and converts it to a int

            intrest = (int)(principal * rate * time); //calculates the amount of intrest owed
            Console.WriteLine("Total intrest of Loan: " + intrest + " dollars."); //lets the user know how much the total intrest of the loan is
        }
    }
}