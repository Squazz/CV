using System.Threading.Tasks;
using CV.GraphQL.Entities;

namespace CV.GraphQL.Repositories
{
    public class SimplePersonRepository : IPersonRepository
    {
        readonly Database.Database _database = new Database.Database();

        public Task<Person> GePersonByIdAsync(int id)
        {
            return _database.GePersonByIdAsync(id);
        }
    }
}