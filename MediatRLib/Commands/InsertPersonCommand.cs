using MediatR;
using MediatRLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRLib.Commands
{
    public record InsertPersonCommand(string firstName, string lastName) : IRequest<PersonModel>
    {
    }


    public class InsertPersonCommandClass :IRequest<PersonModel>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public InsertPersonCommandClass(string firstName, string lastName) 
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
