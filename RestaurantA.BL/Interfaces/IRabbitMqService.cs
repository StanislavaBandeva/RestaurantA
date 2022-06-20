using RestaurantA.Models;
using System.Threading.Tasks;

namespace RestaurantA.BL.Interfaces
{
    public interface IOrderMqService
    {
        Task PublishOrderAsync(Order order);
    }
}
