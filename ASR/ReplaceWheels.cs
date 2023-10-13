using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASR
{
    internal class ReplaceWheels : IService
    {
        public Payment paymentWheels { get; set; }
        public ReplaceWheels(Payment payment)
        {
            paymentWheels = payment;
        }
        public string DoIt(int state)
        {            
            Console.WriteLine("хотите заменить шины и диски?");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    string tool = "wheel";                    
                    paymentWheels.PayChoice(tool);
                    break;
                case 0:
                    Console.WriteLine("noooooo");
                    break;
                default:
                    Console.WriteLine("1 - yes, 0 - no");
                    break;
            }
            return "";
            
        }
    }
}
