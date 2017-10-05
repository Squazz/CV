using System.Collections.Generic;
using CV.GraphQL.Entities;

namespace CV.GraphQL.Repositories
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetCompanies(Person character);
    }
}