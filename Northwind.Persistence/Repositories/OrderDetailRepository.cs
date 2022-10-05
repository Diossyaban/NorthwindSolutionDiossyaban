using Microsoft.EntityFrameworkCore;
using Northwind.Domain.Models;
using Northwind.Domain.Repositories;
using Northwind.Persistence.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Persistence.Repositories
{
    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(NorthwindContext dbContext) : base(dbContext)
        {
        }

        public void Edit(OrderDetail orderDetail)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<OrderDetail>> GetAllOrder(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(o => o.OrderId).ToListAsync();
        }

        public async Task<OrderDetail> GetOrderDetailsById(int orderId, bool trackChanges)
        {
            return await FindByCondition(o => o.OrderId.Equals(orderId), trackChanges).SingleOrDefaultAsync();
        }

        public void Insert(OrderDetail orderDetail)
        {
            throw new NotImplementedException();
        }

        public void Remove(OrderDetail orderDetail)
        {
            throw new NotImplementedException();
        }
    }
}
