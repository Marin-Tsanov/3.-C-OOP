namespace BankAccounts
{
    using System;

    public class BankSystemMain
    {
        public static void Main()
        {
            // Some tests
            Console.WriteLine("Deposit Account: ");

            var depositAcc = new DepositAccount(new Individual("Tanya Skovska", 213, new DateTime(1994, 5, 26), Gender.Female), 200000, 4);
            Console.WriteLine(depositAcc.ToString());
            depositAcc.AddMoney(20000);
            depositAcc.WithdrawMoney(213);

            Console.WriteLine("{0} Interest amount: {1}%", depositAcc.GetType().Name, depositAcc.InterestAmount(8)); // interest amount method

            Console.WriteLine(new string('-', 50));

            var companyDeposit = new DepositAccount(new Company("Microsoft INC", 12345, "Bil Geits"), 44352423432, 234);
            Console.WriteLine(companyDeposit.ToString());

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Loan Deposit: ");
            var loanDeposit = new LoanAccount(new Individual("Pesho Peshov", 213, new DateTime(1990, 12, 16), Gender.Male), 2000, 2);
            Console.WriteLine(loanDeposit.ToString());
            Console.WriteLine("Interest amount {0}%", loanDeposit.InterestAmount(12));
            loanDeposit.AddMoney(23456);

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Mortgage Deposit");
            var mortgageAcc = new MortgageAccount(new Company("BFS", 12383128, "Golqmata Peruka"), 2500000, 0.1m);
            Console.WriteLine(mortgageAcc.ToString());
            Console.WriteLine("Interest amount {0}%", mortgageAcc.InterestAmount(12));

        }
    }
}