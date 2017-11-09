using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Zza.Entities;

namespace Zza.Services
{
    [ServiceContract]
    interface IZzaService
    {
        [OperationContract]
        List<Product> GetProducts();


        [OperationContract]
        List<Customer> GetCustomers();

        [OperationContract]
        void SubmitOrder(Order order);
    }
}
