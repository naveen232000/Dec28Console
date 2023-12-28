using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Dec28Console
{
    public class EncapsulationBank
    {
        private decimal balance;
        public decimal Bal
        {
            get { return balance; }
        }
        public EncapsulationBank(decimal MinBal)
        {
            try {
                balance += MinBal;
                
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine(e.Message);
            }
        }
        public void DepositAmt(decimal Amount)
        {
            if (Amount <= 0)
            {
                Console.WriteLine("OOPS! Deposit Ammount Alleast 500"); 
            }
            else
            {
                try
                {
                    Console.WriteLine(" Amount Deposited: " + Amount);
                    balance += Amount;
                    Console.WriteLine("Balance :" + balance);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public void WithdrawAmt(decimal Amount)
        {
            if (Amount <= 0)
            {
              
                Console.WriteLine("OOPS! Withdrawl Minimun 100");
            }
            else if (balance <= 0)
            {
                Console.WriteLine("Insufficient Balance !!!");
            }
            else
            {
                try
                {

                    Console.WriteLine("Amount WithDrawn: " + Amount);
                    balance -= Amount;
                    Console.WriteLine("Balance :" + balance);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
    public class WorkWithBank:EncapsulationBank
    {
        public WorkWithBank(decimal MinBal) : base(MinBal)
        {
            
        }

        public void menu()
        {
            Console.WriteLine("\nEnter Your Choice:\n1 => Deposit\n2 => Withdrawl");
            int a= Convert.ToInt32(Console.ReadLine());
            if (a >= 1 && a <= 2) {
                switch (a)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Amount to Deposit");
                            decimal damt = Convert.ToDecimal(Console.ReadLine());
                            DepositAmt(damt);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Amount to Withdrawl");
                            decimal wamt = Convert.ToDecimal(Console.ReadLine());
                            WithdrawAmt(wamt);
                            break;
                        }
                    default:
                        { break; }
                } }
            else { Console.WriteLine("OOPS! Enter Correct Choice"); }
                  
            
        }
        static void Main(string[] args)
        {
            //EncapsulationBank bank = new EncapsulationBank(500);
            //Console.WriteLine("Current Balance: " + bank.Bal);
            WorkWithBank workWithBank = new WorkWithBank(500);
            Console.WriteLine("Current Balance: " + workWithBank.Bal);
            while (true)
            {
                workWithBank.menu();
            }
    
        }
    }
}
