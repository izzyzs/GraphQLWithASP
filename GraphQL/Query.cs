namespace GraphQLDemo.GraphQL;

[QueryType]
public class Query
{
    public User GetUser()
    {
        return new User
        {
            Id = 1,
            Name = "Alice",
            Posts = new List<Post>
            {
                new Post { Id = 1, Title = "GraphQL Basics" }
            }
        };
    }

    public List<User> GetUsers()
    {
        return new List<User> =
        {
            {}
        };
    }
}

public class QueryType : ObjectType<Query>
{
    protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
    {
        descriptor
            .Field(f => f.GetUser())
            .Type<UserType>();
        
        descriptor
            .Field(f => f.GetUsers())
            .Type<ListType<UserType>>();
    }
}

public class UserType : ObjectType<User>
{
    protected override void Configure(IObjectTypeDescriptor<User> descriptor)
    {
        descriptor
            .Field(f => f.Id)
            .Type<IntType>();
        
        descriptor
            .Field(f => f.Name)
            .Type<StringType>();

        descriptor
            .Field(f => f.Posts)
            .Type<ListType<StringType>>();
    }
}