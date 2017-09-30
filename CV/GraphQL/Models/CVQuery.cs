using GraphQL.Types;

namespace CV.GraphQL.Models
{
    public class CVQuery : ObjectGraphType
    {
        public CVQuery()
        {
            Name = "Query";

            var database = new Database();

            Field<PersonType>(
                "person",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>>
                    {
                        Name = "id",
                        Description = "Id of the person",
                        //DefaultValue = 1 // Didn't work as expected :/
                    }
                ),
                resolve: context => database.GePersonByIdAsync(context.GetArgument<int>("id"))
            );
        }
    }
}