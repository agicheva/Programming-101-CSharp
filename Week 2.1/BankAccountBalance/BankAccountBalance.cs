using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BankAccountBalance
{
    class BankAccountBalance
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\IVAN\Desktop\HackBulgaria 101 C#\Week 2.1\BankAccountBalance\bin\Debug\BankBalance.txt";
            string[] file = File.ReadAllLines(path);

            ChecBankAccount(file, new DateTime(2015, 3, 25), new DateTime(2015, 3,28));
        }

        static void ChecBankAccount(string[] file, DateTime start, DateTime end)
        {
            for (int  i= 0; i < file.Length; i++)
            {
                string[] splittedLine = file[i].Split(';');
                DateTime startDate = DateTime.Parse(splittedLine[0]);

                if (startDate <= end && startDate >= start)
                {
                    Console.WriteLine(file[i]);
                }
            }
            
        }
    }
}
