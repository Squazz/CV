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
            //Field(x => x.Companies).Description("Persons companies");
            Field<ListGraphType<CompanyType>>(
                name: "companies",
                resolve: context => data.GetCompanies(context.Source),
                description: "Persons companies"
            );
            Field<ListGraphType<EducationType>>(
                name: "educations",
                resolve: context => data.GetEducations(context.Source),
                description: "Persons educations"
            );
            Field<ListGraphType<SkillType>>(
                name: "skills",
                resolve: context => data.GetSkills(context.Source),
                description: "Persons skills"
            );
            Field(x => x.Age).Description("A persons age");
        }
    }
}