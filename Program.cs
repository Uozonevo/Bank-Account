using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE_2310_Homework_11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount(65349721, 435.87, "Jane Doe");

            Console.WriteLine("-----------------Bank Account Class-----------------");
            Console.WriteLine(acc.ToString());

            Checking check01 = new Checking(273880166, 3487.29, "John Doe", 76.33);

            Console.WriteLine("-----------------Checking Account Class-----------------");
            Console.WriteLine(check01.ToString());

            Savings save01 = new Savings(65349721, 435.87, "Jane Doe",35);

            Console.WriteLine("-----------------Savings Account Class-----------------");
            Console.WriteLine(save01.ToString());
            Console.ReadLine();
            
        }
    }
}
