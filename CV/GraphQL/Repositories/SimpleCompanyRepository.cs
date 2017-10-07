using System.Collections.Generic;
using System.Threading.Tasks;
using CV.GraphQL.Entities;

namespace CV.GraphQL.Repositories
{
    public class SimpleCompanyRepository : ICompanyRepository
    {
        readonly Database.Database _database = new Database.Database();

        public IEnumerable<Company> GetCompanies(Person character)
        {
            return _database.GetCompanies(character);
        }

        public Task<Company> GetCompanydByIdAsync(int id)
        {
            return _database.GetCompanydByIdAsync(id);
        }
    }
}