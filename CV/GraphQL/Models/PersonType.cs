using GraphQL.Types;

namespace CV.GraphQL.Models
{
    public class PersonType : ObjectGraphType<Person>
    {
        public PersonType()
        {
            Field(x => x.Id).Description("Persons Id");
            Field(x => x.Name).Description("Persons name");
            Field(x => x.Companies).Description("Personss companies");
            Field(x => x.Educations).Description("Personss educations");
            Field(x => x.Skills).Description("Personss skills");
            Field(x => x.Age).Description("A persons age");
        }
    }
}