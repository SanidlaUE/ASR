using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASR
{
    internal class ReplaceOilService : IService
    {
        public Payment paymentOil {  get; set; }
        public ReplaceOilService(Payment payment)
        {
            paymentOil = payment;
        }
                
        public string DoIt(int state)
        {           
            Console.WriteLine("хотите заменить масло?");            
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    string tool = "oil";                       
                    paymentOil.PayChoice(tool);
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
