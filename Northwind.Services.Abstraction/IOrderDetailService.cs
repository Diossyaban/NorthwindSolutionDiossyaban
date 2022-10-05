using Northwind.Contracts.Dto.OrderDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Services.Abstraction
{
    public interface IOrderDetailService
    {
        Task<IEnumerable<OrderDetailDto>> GetAllOrderDetail(bool trackChanges);
        Task<OrderDetailDto> GetOrderDetailById(int orderid, bool trackChanges);
        
        void Insert (OrderDetailForCreateDto orderDetailForCreateDto);
        void Edit(OrderDetailDto orderDetailDto);
        void Remove(OrderDetailDto orderDetailDto);
    }

}
