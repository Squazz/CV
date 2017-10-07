using System.Collections.Generic;
using System.Threading.Tasks;
using CV.GraphQL.Entities;

namespace CV.GraphQL.Repositories
{
    public interface ISkillRepository
    {
        IEnumerable<Skill> GetSkills(Person character);
        Task<Skill> GetSkillByIdAsync(int id);
    }
}