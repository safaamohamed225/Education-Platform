using EduSpark.Data.Entities;
using EduSpark.Data;
using EduSpark.Service;
using Microsoft.EntityFrameworkCore;

namespace EduSpark.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var configuration = builder.Configuration;

            // DbContext
            //builder.Services.AddDbContext<EduSparkDbContext>(options =>
            //    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
            //);
            builder.Services.AddDbContextPool<EduSparkDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                sqlOptions => sqlOptions.EnableRetryOnFailure()
                );
            });

            // Services & Repositories
            builder.Services.AddScoped<ICourseCategoryRepository, CourseCategoryRepository>();
            builder.Services.AddScoped<ICourseCategoryService, CourseCategoryService>();

            builder.Services.AddControllers();

            // Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}