using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASR
{
    internal class OilCheckService : IService
    {
        public string DoIt(int state)
        {
            Console.WriteLine("вы хотите проверить масло?");
            string choise = Console.ReadLine();
            string res;
            if (choise == "y")
            {
                Random random = new Random();
                int r = random.Next(0, 2);
                if (r == 0)
                {
                    res = "u need replace oil";
                }
                else
                {
                    res = "Oil is ok";
                }               
                return res;
            }
            else { return "ok"; }
        }
    }
}
