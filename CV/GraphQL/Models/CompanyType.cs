using CV.GraphQL.Entities;
using CV.GraphQL.Repositories;
using GraphQL.Types;

namespace CV.GraphQL.Models
{
    public class CompanyType : ObjectGraphType<Company>
    {
        private IProjectRepository _projectRepository;

        //public CompanyType(IProjectRepository projectRepository)
        //{
        //    _projectRepository = projectRepository;

        public CompanyType()
        {
            _projectRepository = new SimpleProjectRepository();

            Field(x => x.Id).Description("Companys Id");
            Field(x => x.Name).Description("Companys name");
            Field<ListGraphType<ProjectType>>(
                name: "companies",
                resolve: context => _projectRepository.GetProjects(context.Source),
                description: "Companys Projects"
            );
        }
    }
}