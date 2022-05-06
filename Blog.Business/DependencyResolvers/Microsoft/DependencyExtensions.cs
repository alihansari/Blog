using Blog.Business.Abstract;
using Blog.Business.Concrete;
using Blog.Data.Abstract;
using Blog.Data.Concrete;
using Blog.Data.Concrete.EntityFramewok.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtensions
    {
        public static void AddDependencies(this IServiceCollection services,IConfiguration _configuration)
        {
            services.AddDbContext<BlogContext>(opt =>
            {
                opt.UseSqlServer(_configuration.GetConnectionString("Local"));
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IArticleService, ArticleManager>();
        }
    }
}
