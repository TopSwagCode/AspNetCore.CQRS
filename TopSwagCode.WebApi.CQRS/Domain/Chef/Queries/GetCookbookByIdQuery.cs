using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TopSwagCode.WebApi.CQRS.Infrastructure;

namespace TopSwagCode.WebApi.CQRS.Domain.Chef.Commands
{

    public class GetCookbookByIdQueryHandler : IRequestHandler<GetCookbookByIdQuery, GetCookbookByIdQueryResult>
    {
        private readonly IProcessProxy _processProxy;

        public GetCookbookByIdQueryHandler(IProcessProxy processProxy)
        {
            _processProxy = processProxy;
        }

        public Task<GetCookbookByIdQueryResult> Handle(GetCookbookByIdQuery request, CancellationToken cancellationToken)
        {
            var result = _processProxy.RunCommand("Chef", "Please create cookbook " + request.Id);

            return Task.FromResult(new GetCookbookByIdQueryResult
            {
                Cookbook = result
            });
        }
    }

    public class GetCookbookByIdQuery : IRequest<GetCookbookByIdQueryResult>
    {
        public GetCookbookByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }

    public class GetCookbookByIdQueryResult
    {
        public string Cookbook { get; set; }
    }
}
