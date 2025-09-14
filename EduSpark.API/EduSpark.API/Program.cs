
using EduSpark.Data;
using EduSpark.Data.Entities;
using EduSpark.Service;
using Microsoft.EntityFrameworkCore;

namespace EduSpark.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var configuration = builder.Configuration;

            builder.Services.AddDbContextPool<EduSparkDbContext>(options =>
               {
                   options.UseSqlServer(configuration.GetConnectionString("DBContext"),
                       providerOptions=>providerOptions.EnableRetryOnFailure());
                   //options.EnableSensitiveDataLogging(true);
               }
               );

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<ICourseCategoryRepository, CourseCategoryRepository>();
            builder.Services.AddScoped<ICourseCategoryService, CourseCategoryService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
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
