using System.Collections.Generic;
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
    }
}