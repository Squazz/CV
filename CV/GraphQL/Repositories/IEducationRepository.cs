using System.Collections.Generic;
using CV.GraphQL.Entities;

namespace CV.GraphQL.Repositories
{
    interface IEducationRepository
    {
        IEnumerable<Education> GetEducations(Person character);
    }
}