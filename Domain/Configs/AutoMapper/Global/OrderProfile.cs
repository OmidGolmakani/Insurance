using AutoMapper;
using Domain.Interfaces.Fundamentals.Request;
using Domain.Models.Dtos.Fundamentals.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configs.AutoMapper.Global
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<IOrderRequest, OrderRequest>().ReverseMap();
            CreateMap<IListOrderRequest, ListOrderRequest>().ReverseMap();


        }
    }
}
