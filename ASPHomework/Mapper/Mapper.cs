using ASPHomework.Controllers.API;
using ASPHomework.Persistence.Entities;
using ASPNetCoreHomework.Models;
using AutoMapper;

namespace ASPHomework.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<OrderFinishViewModel, Order>();
            CreateMap<Destination, DestinationsController.DestinationDto>();
            CreateMap<DestinationTerm, DestinationsController.DestinationTermDto>();
        }
    }
}