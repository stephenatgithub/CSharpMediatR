# CQRS and MediatR in ASP.NET Core

- read side (event sourcing, eventual consistency, eventbus)

- write side (domain driven design, asynchronous message queue)



# MediatR Handler

- Index.razor

`await _mediator.Send(new GetPersonListQuery());`

- GetPersonListHandler.cs

`public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>`

type of request = GetPersonListQuery

type of response = List<PersonModel>

`public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)`

return the result


# Update data in singleton

`builder.Services.AddSingleton<IDataAccess, DataAccess>();`


