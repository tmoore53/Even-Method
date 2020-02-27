using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Even(626);
            Even(763);

        }
        //Even Method takes in one integer perameter and retruns a response of it being even or odd.
        static void Even(int input)
        {
            int output = input % 2;
            if (output == 0)
            {
                Console.WriteLine($"{input} is a even number.");
            }
            else
            {
                Console.WriteLine($"{input} is a odd number.");
            }


        }
    }
}
