using GraphQL.Types;

namespace CV.GraphQL.Models
{
    public class CVQuery : ObjectGraphType
    {
        public CVQuery()
        {
            Field<ProjectType>("hero", resolve: context => new Project { Id = 1, Name = "R2-D2" });
            Field<PersonType>("person", resolve: context => new Person { Id = 1, Name = "Mr Happy", Age = 32 });

            // Field<PersonType>("person", resolve: context => new Person { Id = 5, FirstName = "Joe", Surname = "Woodward", Age = 32 });
        }
    }
}