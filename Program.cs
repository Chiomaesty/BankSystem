
class Program
{
    static decimal InitialBalance()
    {
        Console.WriteLine("enter initial balance");
        decimal formerBalance;

        while (!decimal.TryParse(Console.ReadLine(), out formerBalance) || formerBalance >= 1)
        {
            Console.WriteLine("invalid input: you have 0 initialbalance:please enter 0");

        }
        return formerBalance;
   
    }
    static decimal Balance()
    {
        Console.WriteLine("enter amount:");
        decimal balance;

        while (!decimal.TryParse(Console.ReadLine(), out balance) || balance < 0)
        {
            Console.WriteLine("invalid input: please enter the right response");
        }
        return balance;
        
    }

    static void Main(string[] args)
    {
     
        Console.WriteLine($"HELLO, WELCOME TO ARIEL BANK ");

        decimal initialBalance = InitialBalance();

       

        while (true)
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("enter 1 for deposit");
            Console.WriteLine("enter 2 for withdrawl");
            Console.WriteLine("enter 3 to check balance");

            int option;

            while (!int.TryParse(Console.ReadLine(), out option) || option >= 4)
            {
                Console.WriteLine("invalid input: please enter the right option");
            }

            while (true)
            {


                if (option == 1)
                {

                    decimal depositamount = Balance();

                    depositamount += initialBalance;
                    Console.WriteLine($"deposited successfully");
                    Console.WriteLine($"your balance is {depositamount} ");
                    Console.WriteLine();
                    break;
                }

                else if (option == 2)
                {

                    decimal withdrawalamount = Balance();

                    withdrawalamount -= initialBalance;
                    Console.WriteLine($"withdrawn successfully");
                    Console.WriteLine($"your balance is {withdrawalamount} ");
                    Console.WriteLine();
                    break ;
                }

                else if (option == 3)
                {
                    Console.WriteLine($"your balance is {initialBalance}");
                    Console.WriteLine();
                   break ;

                }
        
            }
            Console.WriteLine("would you like to perform another transation");
            Console.WriteLine("YES: enter 1");
            Console.WriteLine("NO: enter 2");
            int response;
            while (!int.TryParse(Console.ReadLine(), out response) || response < 0)
            {
                Console.WriteLine("please pick the right response");
            }

            if (response == 2)
            {
                Console.WriteLine("THANK YOU FOR BANKING WITH US");
                break;
            }
            else if (response == 1)
            {
                Console.WriteLine();
                continue;
            }

        }
    }

}


