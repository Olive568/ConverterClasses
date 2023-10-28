using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class ComputationClass
    {
        public string Comp()
        {
            string ans = "";
            string Startnum = StartingNumber();
            ans = ConversionChoice(Startnum);
            return ans;
        }
        private string StartingNumber() 
        {
            string startnum = "";
            {
                int check = 0;
                Console.WriteLine("Pick a number from 0 and 65535.");
                startnum = Console.ReadLine();
                try
                {
                    check = int.Parse(startnum);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"{startnum} is not a number. Press any key to retry");
                    Console.ReadKey();
                    Console.Clear();
                    StartingNumber();
                }
                Console.Clear();
                if(check > 65535 || check < 0) 
                {
                    Console.WriteLine("Number is not within the boundaries. Press any Key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    StartingNumber();
                }

            }
            return startnum;
        }
        private string ConversionChoice(string startnum) 
        {
            int choice = 0;
            string ans = "";
            Console.WriteLine("Input these numbers to Convert: 1 = Binary, 2 = Octal, 3 = Hexadecimal");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Clear();
            }

            Console.Clear();
            switch(choice)
            {
                case 1:
                    ans = BinaryConverter(startnum);
                    return ans;
                case 2:
                    ans = OctalConverter(startnum);
                    return ans;
                case 3:
                    ans = HexConverter(startnum);
                    return ans;
                default:
                    Console.WriteLine("that is not a valid choice. Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    return ConversionChoice(startnum);
            }
        }
        private string BinaryConverter(string startnum)
        {
            string ans = "";
            int StartingNumber = int.Parse(startnum);
            while(StartingNumber > 0)
            {
                int remainder = StartingNumber % 2;
                StartingNumber /= 2;
                ans += remainder.ToString();
            }
            while (ans.Length < 16)
            {
                ans += 0;
            }
            return ans;

        }
        private string OctalConverter(string startnum) 
        {
            {
                string ans = "";
                int StartingNumber = int.Parse(startnum);
                while (StartingNumber > 0)
                {
                    int remainder = StartingNumber % 8;
                    StartingNumber /= 8;
                    ans += remainder.ToString();
                }
                while (ans.Length < 6)
                {
                    ans += 0;
                }
                return ans;

            }
        }
        private string HexConverter(string startnum) 
        {
            string[] Letter = new string[6] { "A", "B", "C", "D", "E", "F" };
            string ans = "";
            int StartingNumber = int.Parse(startnum);
            while (StartingNumber > 0)
            {
                int remainder = StartingNumber % 16;       
                StartingNumber /= 16;
                if (remainder > 9 & remainder < 17)
                {
                    remainder -= 10;
                    ans += Letter[remainder];
                }
                else
                    ans += remainder.ToString();
            }
            while(ans.Length < 4)
            {
                ans += 0;
            }
            return ans;
        }
       
    }
}
