namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nolansAcct = new BankAccount();
            nolansAcct.Deposit();
            nolansAcct.GetBalance();
        }
    }
}
