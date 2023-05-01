namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.WriteLine("Enter your deposit amount:");
            account.Deposit(Convert.ToDouble(Console.ReadLine()));

            account.GetBalance();
            Console.WriteLine("Your balance is:");
            Console.WriteLine(account.GetBalance());

            //In the main method of your application, create a new instance of the BankAccount class.
            //Allow the user of the application to Deposit money and retrieve their balance through the console.
        }
    }
}
