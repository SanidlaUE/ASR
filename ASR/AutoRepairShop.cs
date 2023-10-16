using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASR
{
    internal class AutoRepairShop
    {
        Payment payment = new Payment();
        

        private IService oilCheckService;
        public  IService OilCheckService
        { get { return oilCheckService; } }


        private IService oilReplaceService;
        public IService OilReplaceService
        { get { return oilReplaceService; } }


        private IService wheelsReplaceService;
        public IService WheelsReplaceService
        { get { return wheelsReplaceService; } }
        public void Start()
        {
            oilCheckService = new OilCheckService();
            oilReplaceService = new ReplaceOilService(payment);
            wheelsReplaceService = new ReplaceWheels(payment);            
        }
        
        
    }
}
