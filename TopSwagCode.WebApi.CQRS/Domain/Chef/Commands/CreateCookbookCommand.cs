using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TopSwagCode.WebApi.CQRS.Domain.Chef.Commands
{
    public class CreateCookbookCommand : IRequest<CreateCookbookCommandResult>
    {
        public CreateCookbookCommand(string pathToCookBook)
        {
            PathToCookBook = pathToCookBook;
        }

        public string PathToCookBook { get; }
    }

    public class CreateCookbookCommandHandler : IRequestHandler<CreateCookbookCommand, CreateCookbookCommandResult>
    {
        public CreateCookbookCommandHandler()
        {

        }

        public Task<CreateCookbookCommandResult> Handle(CreateCookbookCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public class CreateCookbookCommandResult
    {
    }
}
