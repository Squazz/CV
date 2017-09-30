using GraphQL.Types;

namespace CV.GraphQL.Models
{
    public class SkillType : ObjectGraphType<Skill>
    {
        public SkillType()
        {
            Field(x => x.Id).Description("Skills Id");
            Field(x => x.Name).Description("Skills name");
        }
    }
}