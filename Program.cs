using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace encaps
{
    class Account()
    {
      private int Accountbalance =1000;     //declare it private
    //     public void setBalance(int amount)
    //     {
    //         Accountbalance = amount;
    //     }
    //     public void getBalance()
    //     {
    //         System.Console.WriteLine("YOUR ACCOUNT BALANCE IS "+ Accountbalance);
    //     }
    // }
    public int balance
    {
        set 
        {
                   
        }

    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account myaccount = new Account();
            myaccount.setBalance(500000);  //the value of the account balance is being changend ; that is why encapsulation is used
            myaccount.getBalance();
            System.Console.ReadLine();
        }
    }
}
