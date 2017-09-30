using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.GraphQL
{
    public class Database
    {
        private readonly List<Person> _persons = new List<Person>();
        private readonly List<Company> _companies = new List<Company>();
        private readonly List<Project> _projects = new List<Project>();
        private readonly List<Education> _educations = new List<Education>();
        private readonly List<Skill> _skills = new List<Skill>();

        public Database()
        {
            _persons.Add(new Person()
            {
                Id = 1,
                Name = "Kasper Ploumgmann",
            });

            _companies.Add(new Company()
            {
                Id = 1,
                Name = "Mindworking",
            });
            
            _projects.Add(new Project()
            {
                Id = 1,
                Name = "Real Estate"
            });

            _educations.Add(new Education()
            {
                Id = 1,
                Name = " Folkeskole"
            });

            _skills.Add(new Skill()
            {
                Id = 1,
                Name = ".NET"
            });
            _skills.Add(new Skill()
            {
                Id = 2,
                Name = "C#"
            });
            _skills.Add(new Skill()
            {
                Id = 3,
                Name = "GraphQL"
            });
        }

        public IEnumerable<Company> GetCompanies(Person character)
        {
            if (character == null)
            {
                return null;
            }

            var companies = new List<Company>();
            var lookup = character.Companies;
            if (lookup != null)
            {
                companies.AddRange(_companies.Where(h => lookup.Contains(h.Id)));
            }
            return companies;
        }

        public Task<Person> GePersonByIdAsync(int id)
        {
            return Task.FromResult(_persons.FirstOrDefault(h => h.Id == id));
        }

        public Task<Company> GetCompanydByIdAsync(int id)
        {
            return Task.FromResult(_companies.FirstOrDefault(h => h.Id == id));
        }
    }
}