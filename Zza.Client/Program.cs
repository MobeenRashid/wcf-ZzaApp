using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zza.Client.CustomProxy;
using Zza.Client.ZzaServices;
using IZzaService = Zza.Client.ZzaServices.IZzaService;

namespace Zza.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //ZzaServiceClient client = new ZzaServiceClient("NetTcpBinding_IZzaService");
            IZzaService client = new ZzaCustomProxy("BasicHttpBinding_IZzaService");

            var products = client.GetProducts();

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }

            Console.ReadLine();
        }
    }
}
