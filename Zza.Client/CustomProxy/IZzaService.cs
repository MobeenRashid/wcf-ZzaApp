﻿using System.Collections.Generic;
using System.ServiceModel;
using Zza.Entities;

namespace Zza.Client.CustomProxy
{
    [ServiceContract]
    public interface IZzaService
    {
        [OperationContract]
        List<Product> GetProducts();


        [OperationContract]
        List<Customer> GetCustomers();

        [OperationContract]
        void SubmitOrder(Order order);
    }
}
