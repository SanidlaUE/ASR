using ASR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        do
        {

            AutoRepairShop autoRepairShop = new AutoRepairShop();
            autoRepairShop.Start();

            Console.WriteLine("Бобро пожаловать,что вы хотите сделать ?");
            Console.WriteLine("1. Проверить масло");
            Console.WriteLine("2. Заменить масло");
            Console.WriteLine("3. Заменить шины");
            Console.WriteLine("0. Выхоц");
            int state = int.Parse(Console.ReadLine());
            string res = "";

            switch (state)
            {
                case 1:
                    res = autoRepairShop.OilCheckService.DoIt(state); break;
                case 2:
                    res = autoRepairShop.OilReplaceService.DoIt(state); break;
                case 3:
                    res = autoRepairShop.WheelsReplaceService.DoIt(state); break;
                case 0:
                    break;
                default: Console.WriteLine("По списку 1,2,3,0"); break;
            }
            Console.WriteLine(res);
            
            Console.WriteLine("выйти = 0 или любая клавиша,чтобы перезапустить консоль");
        }
        while ((Console.ReadLine() != "0"));



    }


}
