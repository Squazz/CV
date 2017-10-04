using CV.GraphQL.Entities;
using GraphQL.Types;

namespace CV.GraphQL.Models
{
    public class CompanyType : ObjectGraphType<Company>
    {
        public CompanyType()
        {
            var data = new Database();

            Field(x => x.Id).Description("Companys Id");
            Field(x => x.Name).Description("Companys name");
            Field<ListGraphType<CompanyType>>(
                name: "companies",
                resolve: context => data.GetProjects(context.Source),
                description: "Companys Projects"
            );
        }
    }
}