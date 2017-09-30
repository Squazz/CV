using GraphQL.Types;

namespace CV.GraphQL.Models
{
    public class CompanyType : ObjectGraphType<Company>
    {
        public CompanyType()
        {
            Field(x => x.Id).Description("Companys Id");
            Field(x => x.Name).Description("Companys name");
            Field(x => x.Projects).Description("Companys Projects");
        }
    }
}