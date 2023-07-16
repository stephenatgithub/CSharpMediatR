using MediatRLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRLib.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private List<PersonModel> people = new();
        public DataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "a", LastName = "a" });
            people.Add(new PersonModel { Id = 2, FirstName = "b", LastName = "b" });

        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPeople(string fn, string ln)
        {
            PersonModel p = new() { FirstName = fn, LastName = ln };
            p.Id = people.Max(x => x.Id) + 1;
            people.Add(p);
            return p;

        }
    }
}
