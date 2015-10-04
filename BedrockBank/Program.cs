using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************Welcome to Bedrock Bank**********");
            Console.Write("Please enter your ssn(without the dashes): ");
            var ssn = Console.ReadLine();
            int convertedSSN;
            if (int.TryParse(ssn, out convertedSSN) == true)
            {
                var accounts = BankFactory.GetAllAccountsBySSN(convertedSSN);
                for (int i = 0; i < accounts.Length; i++)
                {
                    Console.WriteLine("{0}. Name: {1}", i + 1, accounts[i].Name);
                }
            }
        }
    }
}
