using CV.GraphQL.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CV
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddTransient<ICompanyRepository, SimpleCompanyRepository>();
            services.AddTransient<IEducationRepository, SimpleEducationRepository>();
            services.AddTransient<ISkillRepository, SimpleSkillRepository>();
            services.AddTransient<IProjectRepository, SimpleProjectRepository>();
            services.AddTransient<IPersonRepository, SimplePersonRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            // Now we can use GraphiQL without handling the pesky Node.JS ourself
            app.UseGraphiQl();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}