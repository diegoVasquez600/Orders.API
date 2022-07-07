using Orders.API.DAO;
using System.Data;

namespace Orders.API.DTO
{
    public class OrdersDTO
    {
        readonly OrdersDAO ordersDAO;
        public OrdersDTO()
        {
            ordersDAO = new OrdersDAO();
        }

        public DataTable GetOrders()
        {
            return ordersDAO.GetOrders();
        }
    }
}
