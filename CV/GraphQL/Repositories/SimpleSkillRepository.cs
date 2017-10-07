using System.Collections.Generic;
using System.Threading.Tasks;
using CV.GraphQL.Entities;

namespace CV.GraphQL.Repositories
{
    public class SimpleSkillRepository : ISkillRepository
    {
        readonly Database.Database _database = new Database.Database();

        public IEnumerable<Skill> GetSkills(Person character)
        {
            return _database.GetSkills(character);
        }

        public Task<Skill> GetSkillByIdAsync(int id)
        {
            return _database.GetSkillByIdAsync(id);
        }
    }
}