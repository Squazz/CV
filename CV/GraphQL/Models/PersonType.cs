using CV.GraphQL.Entities;
using GraphQL.Types;

namespace CV.GraphQL.Models
{
    public class PersonType : ObjectGraphType<Person>
    {
        public PersonType()
        {
            var data = new Database();
            
            Field(x => x.Id).Description("Persons Id");
            Field(x => x.Name).Description("Persons name");
            Field(x => x.Companies).Description("Persons companies");
            //Field<ListGraphType<CompanyInterface>>(
            //    name: "companies",
            //    resolve: context => data.GetCompanies(context.Source),
            //    description: "Persons companies"
            //);
            Field(x => x.Educations).Description("Persons educations");
            Field(x => x.Skills).Description("Persons skills");
            Field(x => x.Age).Description("A persons age");
        }
    }
}