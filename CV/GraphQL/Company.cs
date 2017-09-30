using System.Collections.Generic;

namespace CV.GraphQL
{
    public class Company : Entity
    {
        public List<int> Projects { get; set; }
    }
}