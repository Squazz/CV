using GraphQL.Types;

namespace CV.GraphQL.Models
{
    public class PersonType : ObjectGraphType<Person>
    {
        public PersonType()
        {
            // Field(x => x.FirstName).Resolve((x) => {
            //     return "Hello!";
            // }).Description("Perso's First Name");

            Field(x => x.Id).Description("Peron's Id");
            Field(x => x.Name).Description("Person's name");
            Field(x => x.Age).Resolve(x => {
                return 25;
            }).Description("A person's age");
        }
    }
}