using AutoMapper;

namespace AT.WebApplication.API.Mappings
{
    public class TransactionProfile : Profile
    {
        public TransactionProfile()
        {
            CreateMap<Domain.Entities.TransactionReport, Models.TransactionReport>();
        }
    }
}