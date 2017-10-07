using System.Collections.Generic;
using System.Threading.Tasks;
using CV.GraphQL.Entities;

namespace CV.GraphQL.Repositories
{
    public interface IProjectRepository
    {
        IEnumerable<Project> GetProjects(Company company);
        Task<Project> GetProjectdByIdAsync(int id);
    }
}