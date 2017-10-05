using System.Collections.Generic;
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
    }
}