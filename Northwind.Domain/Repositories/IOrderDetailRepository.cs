using Northwind.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Domain.Repositories
{
    public interface IOrderDetailRepository
    {
        Task<IEnumerable<OrderDetail>> GetAllOrder(bool trackChanges);
        Task<OrderDetail> GetOrderDetailsById (int orderId,bool trackChanges);
        Task<OrderDetail> GetOrderDetail(int orderId, int productId, bool trackChanges);

        void Insert(OrderDetail orderDetail);
    void Edit(OrderDetail orderDetail);
    void Remove(OrderDetail orderDetail);

        /*public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }*/
    }
}
