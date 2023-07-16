using MediatRLib.Models;

namespace MediatRLib.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel InsertPeople(string fn, string ln);
    }
}