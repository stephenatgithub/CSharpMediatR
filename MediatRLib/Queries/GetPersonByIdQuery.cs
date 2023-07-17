using MediatR;
using MediatRLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRLib.Queries
{
    public record GetPersonByIdQuery(int id) : IRequest<PersonModel>
    {
    }

    public class GetPersonByIdQueryClass
    {
        public int Id { get; set; }

        public GetPersonByIdQueryClass(int id)
        {
            Id = id;
        }
    }
}
