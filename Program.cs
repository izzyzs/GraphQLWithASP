using GraphQLDemo.GraphQL;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddFiltering()
    .AddSorting();

var app = builder.Build();

app.MapGraphQL();

app.Run();

// public class Query
// {
    // public string HelloWorld() => "Hello, GraphQL!";
// }