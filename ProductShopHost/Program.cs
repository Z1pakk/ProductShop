using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ProductShopHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host=new ServiceHost(typeof(ProductShopLibrary.AccountService)))
            {
                host.Open();
                Console.WriteLine("Host started!");
                Console.ReadKey();
            }
        }
    }
}
