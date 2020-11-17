using AutoMapper;

namespace AT.WebApplication.API.Mappings
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<Domain.Entities.Account, Models.Account>();
        }
    }
}