using CV.GraphQL.Entities;
using GraphQL.Types;

namespace CV.GraphQL.Models
{
    public class ProjectType : ObjectGraphType<Project>
    {
        public ProjectType()
        {
            Field(x => x.Id).Description("The Id of the Project.");
            Field(x => x.Name, nullable: true).Description("The name of the Project.");
        }
    }
}