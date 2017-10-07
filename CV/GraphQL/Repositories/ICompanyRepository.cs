using System.Collections.Generic;
using System.Threading.Tasks;
using CV.GraphQL.Entities;

namespace CV.GraphQL.Repositories
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetCompanies(Person character);
        Task<Company> GetCompanydByIdAsync(int id);
    }
}