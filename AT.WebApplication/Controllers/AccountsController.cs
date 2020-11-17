using AT.WebApplication.API.Models;
using AT.WebApplication.Application.Accounts.Queries.GetAccounts;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AT.WebApplication.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public AccountsController(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<Account>> Get()
        {
            var accounts = await mediator.Send(new GetAccountsQuery());

            var response = mapper.Map<IEnumerable<Account>>(accounts);

            return response;
        }
    }
}