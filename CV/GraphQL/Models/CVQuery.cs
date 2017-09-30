using GraphQL.Types;

namespace CV.GraphQL.Models
{
    public class CVQuery : ObjectGraphType<object>
    {
        public CVQuery()
        {
            Name = "Query";

            var database = new Database();

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
                resolve: context => database.GePersonByIdAsync(context.GetArgument<int>("id"))
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
                resolve: context => database.GetCompanydByIdAsync(context.GetArgument<int>("id"))
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
                resolve: context => database.GetProjectdByIdAsync(context.GetArgument<int>("id"))
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
                resolve: context => database.GetSkillByIdAsync(context.GetArgument<int>("id"))
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
                resolve: context => database.GetSkillByIdAsync(context.GetArgument<int>("id"))
            );
        }
    }
}