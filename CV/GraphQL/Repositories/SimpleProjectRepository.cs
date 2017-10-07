using System.Collections.Generic;
using System.Threading.Tasks;
using CV.GraphQL.Entities;

namespace CV.GraphQL.Repositories
{
    public class SimpleProjectRepository : IProjectRepository
    {
        readonly Database.Database _database = new Database.Database();

        public IEnumerable<Project> GetProjects(Company company)
        {
            return _database.GetProjects(company);
        }

        public Task<Project> GetProjectdByIdAsync(int id)
        {
            return _database.GetProjectdByIdAsync(id);
        }
    }
}