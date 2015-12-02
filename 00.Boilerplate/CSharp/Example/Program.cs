using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static int gcd(int i, int j)
        {
            if (j == 0) return i;
            int k = i % j;
            return gcd(j, k);
        }

        static void Main(string[] args)
        {
            int length = -1;
            int i, j, inputGcd;
            string s;

            using (StreamReader stdIn = new StreamReader(Console.OpenStandardInput()))
            {
                while ((s = stdIn.ReadLine()) != null)
                {
                    if (length == -1)
                    {
                        if (!Int32.TryParse(s, out length))
                            throw new Exception("Wrong input format");
                        else
                            s = stdIn.ReadLine();
                    }

                    string[] inputNumbers = s.Split(' ');
                    Int32.TryParse(inputNumbers[0], out i);
                    Int32.TryParse(inputNumbers[1], out j);
                    Int32.TryParse(inputNumbers[2], out inputGcd);

                    int actualGcd = gcd(i, j);
                    if (actualGcd == inputGcd)
                        Console.WriteLine("OK");
                    else
                        Console.WriteLine(actualGcd);
                }
            }
        }
    }
}
