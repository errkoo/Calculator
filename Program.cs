using System.Linq.Expressions;
using System.Transactions;
using System.Xml;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Choose converter:");
                Console.WriteLine("1 - Euro to BGN");
                Console.WriteLine("2 - BGN to Euro");
                Console.WriteLine("3 - Exit");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        EuroToBGN();

                    }
                    else if (choice == 2)
                    {
                        BGNToEuro();
                    }
                    else if (choice == 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid Choice");
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine("Enter Valid Choice");
                }

             
            }
        }
        public static void EuroToBGN()
        {
            Console.WriteLine("Enter Amount in Euro");
            double amount = Convert.ToDouble(Console.ReadLine());
            Calculate calculate = new Calculate(amount, 1);
            Console.WriteLine($"{calculate.returnAmount()} BGN");
            
        }
        public static void BGNToEuro()
        {
            Console.WriteLine("Enter Amount");
            double amount = Convert.ToDouble(Console.ReadLine());
            Calculate calculate = new Calculate(amount, 2);
            Console.WriteLine(calculate.returnAmount());
        }
    }
}
