using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestaurantA.Models;

namespace RestaurantA.DL
{
    public interface IOrderRepository
    {
        Task Add(Order order);

        Task<IEnumerable<IOrderRepository>> GetAll();

        Task<IEnumerable<Order>> GetAllByYear(int Year);
    }
}
