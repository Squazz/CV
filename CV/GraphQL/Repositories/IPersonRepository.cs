using System.Threading.Tasks;
using CV.GraphQL.Entities;

namespace CV.GraphQL.Repositories
{
    public interface IPersonRepository
    {
        Task<Person> GePersonByIdAsync(int id);
    }
}