using CV.GraphQL.Entities;
using CV.GraphQL.Repositories;
using GraphQL.Types;

namespace CV.GraphQL.Models
{
    public class PersonType : ObjectGraphType<Person>
    {
        private ICompanyRepository _companyRepository;
        private IEducationRepository _educationRepository;
        private ISkillRepository _skillRepository;

        public PersonType()
        {
            _companyRepository = new SimpleCompanyRepository();
            _educationRepository = new SimpleEducationRepository();
            _skillRepository = new SimpleSkillRepository();
            
            Field(x => x.Id).Description("Persons Id");
            Field(x => x.Name).Description("Persons name");
            //Field(x => x.Companies).Description("Persons companies");
            Field<ListGraphType<CompanyType>>(
                name: "companies",
                resolve: context => _companyRepository.GetCompanies(context.Source),
                description: "Persons companies"
            );
            Field<ListGraphType<EducationType>>(
                name: "educations",
                resolve: context => _educationRepository.GetEducations(context.Source),
                description: "Persons educations"
            );
            Field<ListGraphType<SkillType>>(
                name: "skills",
                resolve: context => _skillRepository.GetSkills(context.Source),
                description: "Persons skills"
            );
            Field(x => x.Age).Description("A persons age");
        }
    }
}