using CV.GraphQL.Entities;
using GraphQL.Types;

namespace CV.GraphQL.Models
{
    public class CompanyInterface : InterfaceGraphType<Company>
    {
        public CompanyInterface()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Projects);
        }
    }
}