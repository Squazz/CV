using System.Collections.Generic;

namespace CV.GraphQL
{
    public class Person : Entity
    {
        public int Age { get; set; }
        public List<int> Companies { get; set; }
    }
}