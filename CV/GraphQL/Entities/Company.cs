using System.Collections.Generic;

namespace CV.GraphQL.Entities
{
    public class Company : Entity
    {
        public List<int> Projects { get; set; }
    }
}