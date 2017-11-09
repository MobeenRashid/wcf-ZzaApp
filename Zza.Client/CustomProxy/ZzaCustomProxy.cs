using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Zza.Entities;

namespace Zza.Client.CustomProxy
{
    public class ZzaCustomProxy : ClientBase<Zza.Client.ZzaServices.IZzaService>, Zza.Client.ZzaServices.IZzaService
    {
        public ZzaCustomProxy()
        {

        }

        public ZzaCustomProxy(string endpointAddress) : base(endpointAddress)
        {

        }




        public Task<Product[]> GetProductsAsync()
        {
            return Channel.GetProductsAsync();
        }

        Customer[] ZzaServices.IZzaService.GetCustomers()
        {
            throw new System.NotImplementedException();
        }

        public Task<Customer[]> GetCustomersAsync()
        {
            throw new System.NotImplementedException();
        }

        Product[] ZzaServices.IZzaService.GetProducts()
        {
            return Channel.GetProducts();
        }



        public void SubmitOrder(Order order)
        {
            Channel.SubmitOrder(order);
        }

        public Task SubmitOrderAsync(Order order)
        {
            throw new System.NotImplementedException();
        }
    }
}
