using RealEstatePlace.Data.Entities;
using System.Collections.Generic;

namespace RealEstatePlace.Data
{
    public interface IRealEstateRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);
        IEnumerable<Order> GetAllOrders(bool includeItems);
        IEnumerable<Order> GetAllOrdersByUser(string username, bool includeItems);
        Order GetOrderById(string userName, int id);
        bool SaveAll();
        void AddEntity(object model);
        
    }
}