using GraphQL.Types;

namespace CV.GraphQL.Models
{
    public class EducationType : ObjectGraphType<Education>
    {
        public EducationType()
        {
            Field(x => x.Id).Description("Educations Id");
            Field(x => x.Name).Description("Educations name");
        }
    }
}