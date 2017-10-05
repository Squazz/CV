using System.Collections.Generic;
using CV.GraphQL.Entities;

namespace CV.GraphQL.Repositories
{
    public interface ISkillRepository
    {
        IEnumerable<Skill> GetSkills(Person character);
    }
}