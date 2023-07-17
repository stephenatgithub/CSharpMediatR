using MediatR;
using MediatRLib.DataAccess;
using MediatRLib.Models;
using MediatRLib.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRLib.Handlers
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
    {
        //private readonly IDataAccess _data;
        //public GetPersonByIdHandler(IDataAccess data)
        //{
        //    _data = data;
        //}

        //public Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        //{
        //    return Task.FromResult(_data.GetPeople());
        //}

        private readonly IMediator _mediator;

        public GetPersonByIdHandler(IMediator mediator)
        {
            _mediator = mediator;            
        }

        public async Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetPersonListQuery());

            var output = results.FirstOrDefault(x => x.Id == request.id);

            return output;
        }
    }


}
