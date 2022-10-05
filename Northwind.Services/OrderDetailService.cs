using AutoMapper;
using Northwind.Contracts.Dto.OrderDetail;
using Northwind.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Domain.Base;
using Northwind.Domain.Models;

namespace Northwind.Services
{
    public class OrderDetailService :IOrderDetailService

    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public OrderDetailService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public void Edit(OrderDetailDto orderDetailDto)
        {
            var edit = _mapper.Map<OrderDetail>(orderDetailDto);
            _repositoryManager.orderDetailRepository.Edit(edit);
            _repositoryManager.Save();
           
        }

        public async Task<IEnumerable<OrderDetailDto>> GetAllOrderDetail(bool trackChanges)
        {
            var OrderDtos = await _repositoryManager.orderDetailRepository.GetAllOrder(trackChanges);
            var orderDetailDtoList = _mapper.Map<IEnumerable<OrderDetailDto>>(OrderDtos);
            return orderDetailDtoList;
        }

        public async Task<OrderDetailDto> GetOrderDetailById(int orderid, bool trackChanges)
        {
            var orderDtos = await _repositoryManager.orderDetailRepository.GetOrderDetailsById(orderid, trackChanges);
            var orderDetailDtoList = _mapper.Map<OrderDetailDto>(orderDtos);
            return orderDetailDtoList;
        }

        public void Insert(OrderDetailForCreateDto orderDetailForCreateDto)
        {
            var insert =_mapper.Map<OrderDetail>(orderDetailForCreateDto);
            _repositoryManager.orderDetailRepository.Insert(insert);
            _repositoryManager.Save();
        }

        public void Remove(OrderDetailDto orderDetailDto)
        {
            var remove = _mapper.Map<OrderDetail>(orderDetailDto);
            _repositoryManager.orderDetailRepository.Remove(remove);
            _repositoryManager.Save();
        }
    }
}
