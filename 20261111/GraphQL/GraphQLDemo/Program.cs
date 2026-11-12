using HotChocolate.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
  .AddQueryType<Query>()
  .AddInterfaceType<IReadingMaterials>()
  .AddMutationType<Mutation>()
  .AddSubscriptionType<Subscription>()
  .AddInMemorySubscriptions();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGraphQL();
app.UseWebSockets();

app.Run();
