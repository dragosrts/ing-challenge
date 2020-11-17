using AT.WebApplication.API.Models;
using AT.WebApplication.Application.Transactions.Queries.GetTransactionsReport;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AT.WebApplication.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public TransactionsController(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("report")]
        public async Task<IEnumerable<TransactionReport>> GetReport()
        {
            var transactions = await mediator.Send(new GetTransactionsReportQuery());

            var response = mapper.Map<IEnumerable<TransactionReport>>(transactions);

            return response;
        }
    }
}