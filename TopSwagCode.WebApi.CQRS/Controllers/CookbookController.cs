using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TopSwagCode.WebApi.CQRS.Domain.Chef.Commands;

namespace TopSwagCode.WebApi.CQRS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CookbookController : ControllerBase
    {

        private readonly ILogger<CookbookController> _logger;
        private readonly IMediator _mediatR;

        public CookbookController(ILogger<CookbookController> logger, IMediator mediatR)
        {
            _logger = logger;
            _mediatR = mediatR;
        }

        [HttpGet("{cookbookId}")]
        public async Task<string> GetCookbookById(int cookbookId)
        {
            var result = await _mediatR.Send(new GetCookbookByIdQuery(cookbookId));

            return result.Cookbook;
        }
    }
}
