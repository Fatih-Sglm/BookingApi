using AutoMapper;
using KodHub.Application.Interfaces.Repositories;
using KodHub.Application.Mapping;
using KodHub.Persistance.Contexts;
using KodHub.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace KodHub.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<KodHubContext>(options => options.UseNpgsql(Configuraiton.ConnectionString()));
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<IWriterRepository, WriterRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            var configuration = new MapperConfiguration(opt => opt.AddProfile(new KodHubProfile()));
            var mapper = configuration.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
