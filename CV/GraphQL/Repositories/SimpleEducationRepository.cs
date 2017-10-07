using System.Collections.Generic;
using System.Threading.Tasks;
using CV.GraphQL.Entities;

namespace CV.GraphQL.Repositories
{
    public class SimpleEducationRepository : IEducationRepository
    {
        readonly Database.Database _database = new Database.Database();

        public IEnumerable<Education> GetEducations(Person character)
        {
            return _database.GetEducations(character);
        }

        public Task<Education> GetEducationByIdAsync(int id)
        {
            return _database.GetEducationByIdAsync(id);
        }
    }
}