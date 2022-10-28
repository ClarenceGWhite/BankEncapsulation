namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TrueCoders National Bank.");
            
            var cAccount = new BankAccount(100);
            Console.WriteLine($"Current Balance is: {cAccount.GetBalance()}");

            Console.WriteLine();
            Console.WriteLine("Enter the amount of your deposit...");
            double depAmount = int.Parse(Console.ReadLine()); 
            cAccount.Deposit(depAmount);
            Console.WriteLine();
            Console.WriteLine($"Your New Balance is: {cAccount.GetBalance()}");
            Console.WriteLine("Thanks for visitng.");

           
        }
    }
}
