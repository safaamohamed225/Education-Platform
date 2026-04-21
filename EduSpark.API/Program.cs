using EduSpark.API.Common;
using EduSpark.Data;
using EduSpark.Data.Entities;
using EduSpark.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;

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
            builder.Services.AddDbContextPool<EduSparkDB>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                sqlOptions => sqlOptions.EnableRetryOnFailure()
                );

                //options.EnableSensitiveDataLogging();
            });

            builder.Services.AddHealthChecks()
                    .AddSqlServer(
                        connectionString: configuration.GetConnectionString("DefaultConnection"),
                        healthQuery: "SELECT 1;", // Query to check database health.
                        name: "sqlserver",
                        failureStatus: HealthStatus.Degraded, // Degraded health status if the check fails.
                        tags: new[] { "db", "sql" })
                    .AddCheck("Memory", new PrivateMemoryHealthCheck(1024 * 1024 * 1024)); // A custom health check for memory.


            builder.Services.AddControllers();
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddAuthentication("Bearer")
            .AddJwtBearer("Bearer", options =>
            {
                options.Authority = configuration["AzureAdB2C:Authority"];
                options.Audience = configuration["AzureAdB2C:ClientId"];
            });

            //builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);
            builder.Services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            builder.Services.AddHttpClient();
            // Services & Repositories
            builder.Services.AddScoped<ICourseCategoryRepository, CourseCategoryRepository>();
            builder.Services.AddScoped<ICourseCategoryService, CourseCategoryService>();

            builder.Services.AddScoped<ICourseRepository, CourseRepository>();
            builder.Services.AddScoped<ICourseService, CourseService>();

            builder.Services.AddScoped<IVideoRequestRepository, VideoRequestRepository>();
            builder.Services.AddScoped<IVideoRequestService, VideoRequestService>();
            builder.Services.AddScoped<IUserClaims, UserClaims>();
            // Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseHttpsRedirection();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}