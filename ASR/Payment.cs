using ASR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASR
{
    internal class Payment
    {
        private int replaceWheels = 300;
        private int replaceOil = 200;
        private int input;
        public void PayChoice(string tool)
        {
            int toolPrice;
            if (tool == "wheel")
            {
                toolPrice = replaceWheels;
                PayReplace(toolPrice,tool);
            }
            else
            {
                toolPrice = replaceOil;
                PayReplace(toolPrice, tool);
            }
        }       

        public void PayReplace(int toolPrice, string tool)
        {
            Console.WriteLine("it cost {0},input money", toolPrice);
            input = int.Parse(Console.ReadLine());
            int priceDifference = toolPrice - input;
            if (priceDifference < 0)
            {
                Console.WriteLine("ur handing over money {0}", priceDifference * -1);
            }
            else if (priceDifference > 0)
            {
                do
                {
                    Console.WriteLine("not enough {0},input more money pls", priceDifference);
                    priceDifference = int.Parse(Console.ReadLine());
                    input += priceDifference;
                } while (input != toolPrice);
                Console.WriteLine("{0} replaced", tool);
            }
            else { Console.WriteLine("{0} replaced", tool); }
        }



    }
}



