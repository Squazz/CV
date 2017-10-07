using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CV.GraphQL.Entities;

namespace CV.GraphQL.Database
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
                Birthday = DateTime.Parse("1991-03-28"),
                Companies = new List<int>() { 1 },
                Educations = new List<int>() { 1, 2, 3, 4, 5 },
                Skills = new List<int>() { 1, 2, 3 }
            });

            _companies.Add(new Company()
            {
                Id = 1,
                Name = "Mindworking",
                Projects = new List<int>() { 1 }
            });
            
            _projects.Add(new Project()
            {
                Id = 1,
                Name = "Real Estate"
            });

            _educations.Add(new Education()
            {
                Id = 1,
                Name = "Folkeskole"
            });
            _educations.Add(new Education()
            {
                Id = 2,
                Name = "Efterskole"
            });
            _educations.Add(new Education()
            {
                Id = 3,
                Name = "Gymnasium / HTX"
            });
            _educations.Add(new Education()
            {
                Id = 4,
                Name = "Højskole"
            });
            _educations.Add(new Education()
            {
                Id = 5,
                Name = "Datalogi påbegyndt"
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

        public IEnumerable<Education> GetEducations(Person character)
        {
            if (character == null)
            {
                return null;
            }

            var educations = new List<Education>();
            var lookup = character.Educations;
            if (lookup != null)
            {
                educations.AddRange(_educations.Where(h => lookup.Contains(h.Id)));
            }
            return educations;
        }

        public IEnumerable<Skill> GetSkills(Person character)
        {
            if (character == null)
            {
                return null;
            }

            var skills = new List<Skill>();
            var lookup = character.Skills;
            if (lookup != null)
            {
                skills.AddRange(_skills.Where(h => lookup.Contains(h.Id)));
            }
            return skills;
        }

        public IEnumerable<Project> GetProjects(Company company)
        {
            if (company == null)
            {
                return null;
            }

            var projects = new List<Project>();
            var lookup = company.Projects;
            if (lookup != null)
            {
                projects.AddRange(_projects.Where(h => lookup.Contains(h.Id)));
            }
            return projects;
        }

        public Task<Person> GePersonByIdAsync(int id)
        {
            return Task.FromResult(_persons.FirstOrDefault(h => h.Id == id));
        }

        public Task<Company> GetCompanydByIdAsync(int id)
        {
            return Task.FromResult(_companies.FirstOrDefault(h => h.Id == id));
        }

        public Task<Project> GetProjectdByIdAsync(int id)
        {
            return Task.FromResult(_projects.FirstOrDefault(h => h.Id == id));
        }

        public Task<Education> GetEducationByIdAsync(int id)
        {
            return Task.FromResult(_educations.FirstOrDefault(h => h.Id == id));
        }

        public Task<Skill> GetSkillByIdAsync(int id)
        {
            return Task.FromResult(_skills.FirstOrDefault(h => h.Id == id));
        }
    }
}