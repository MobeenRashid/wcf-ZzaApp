using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Zza.Services;

namespace Zza.Selfhost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ZzaService));
            host.Open();
            Console.WriteLine("Hit any key to stop the host.");

            Console.ReadLine();
            host.Close();
        }
    }
}
