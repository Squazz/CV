using System.Collections.Generic;
using CV.GraphQL.Entities;

namespace CV.GraphQL.Repositories
{
    public interface IProjectRepository
    {
        IEnumerable<Project> GetProjects(Company company);
    }
}