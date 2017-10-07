using System.Collections.Generic;
using System.Threading.Tasks;
using CV.GraphQL.Entities;

namespace CV.GraphQL.Repositories
{
    public interface IEducationRepository
    {
        IEnumerable<Education> GetEducations(Person character);
        Task<Education> GetEducationByIdAsync(int id);
    }
}