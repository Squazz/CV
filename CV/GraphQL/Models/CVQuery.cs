using CV.GraphQL.Repositories;
using GraphQL.Types;

namespace CV.GraphQL.Models
{
    public class CVQuery : ObjectGraphType<object>
    {
        private ICompanyRepository _companyRepository;
        private IEducationRepository _educationRepository;
        private ISkillRepository _skillRepository;
        private IPersonRepository _personRepository;
        private IProjectRepository _projectRepository;

        //public CVQuery(ICompanyRepository companyRepository, IEducationRepository educationRepository, ISkillRepository skillRepository, IPersonRepository personRepository, IProjectRepository projectRepository)
        //{
        //    _companyRepository = companyRepository;
        //    _educationRepository = educationRepository;
        //    _skillRepository = skillRepository;
        //    _personRepository = personRepository;
        //    _projectRepository = projectRepository;

        public CVQuery()
        {
            _companyRepository = new SimpleCompanyRepository();
            _educationRepository = new SimpleEducationRepository();
            _skillRepository = new SimpleSkillRepository();
            _personRepository = new SimplePersonRepository();
            _projectRepository = new SimpleProjectRepository();

            Name = "Query";

            Field<PersonType>(
                "person",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>>
                    {
                        Name = "id",
                        Description = "Id of the person",
                        //DefaultValue = 1 // Didn't work as expected :/
                    }
                ),
                resolve: context => _personRepository.GePersonByIdAsync(context.GetArgument<int>("id"))
            );

            Field<CompanyType>(
                "company",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>>
                    {
                        Name = "id",
                        Description = "Id of the company",
                        //DefaultValue = 1 // Didn't work as expected :/
                    }
                ),
                resolve: context => _companyRepository.GetCompanydByIdAsync(context.GetArgument<int>("id"))
            );

            Field<ProjectType>(
                "project",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>>
                    {
                        Name = "id",
                        Description = "Id of the company",
                        //DefaultValue = 1 // Didn't work as expected :/
                    }
                ),
                resolve: context => _projectRepository.GetProjectdByIdAsync(context.GetArgument<int>("id"))
            );

            Field<EducationType>(
                "education",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>>
                    {
                        Name = "id",
                        Description = "Id of the company",
                        //DefaultValue = 1 // Didn't work as expected :/
                    }
                ),
                resolve: context => _educationRepository.GetEducationByIdAsync(context.GetArgument<int>("id"))
            );

            Field<SkillType>(
                "skill",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>>
                    {
                        Name = "id",
                        Description = "Id of the company",
                        //DefaultValue = 1 // Didn't work as expected :/
                    }
                ),
                resolve: context => _skillRepository.GetSkillByIdAsync(context.GetArgument<int>("id"))
            );
        }
    }
}