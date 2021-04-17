using System;
using System.Collections.Generic;
using BankLibrary;

namespace BankProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BankRepository obj = new BankRepository();
            SBAccount sb1 = new SBAccount();
            Console.WriteLine("Welcome to the Banking Project");
            Console.WriteLine("Choose the option from below menu");
            Console.WriteLine("1... Add a new Account");
            Console.WriteLine("2... View List of  Accounts"); 
            Console.WriteLine("3... Deposit Amount");
            Console.WriteLine("4... Withdraw Amount");
            Console.WriteLine("5... View Account Detail");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter Account Number");
                        sb1.AccountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Customer Name");
                        sb1.CustomerName = Console.ReadLine();
                        Console.WriteLine("Enter Address");
                        sb1.CustomerAddress = Console.ReadLine();
                        Console.WriteLine("Enter Current Balance");
                        sb1.CurrentBalance = Convert.ToInt32(Console.ReadLine());
                        obj.NewAccount(sb1);
                        Console.WriteLine("Your Account is Successfully Added");
                        break;
                    }
                case 2:
                    {
                        List<SBAccount> result=obj.GetAllAccounts();
                        foreach(var item in result)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("How much amount you want to Deposit");
                        decimal amt = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Please Enter your Account Number");
                        int accno = Convert.ToInt32(Console.ReadLine());
                        double balance=obj.DepositAmount(accno, amt);
                        Console.WriteLine("Your Current Balance is :" + balance);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("How much amount you want to Withdraw");
                        decimal amt = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Please Enter your Account Number");
                        int accno = Convert.ToInt32(Console.ReadLine());
                        double balance = obj.WithdrawAmount(accno, amt);
                        Console.WriteLine("Your Current Balance is :" + balance);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Please Enter your Account Number");
                        int accno = Convert.ToInt32(Console.ReadLine());
                        SBAccount s= obj.GetAccountDetails(accno);
                        Console.WriteLine("Your Details are :");
                        Console.WriteLine(s.ToString());
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please Enter a valid choice");
                        break;
                    }
            }
            

        }
    }
}
