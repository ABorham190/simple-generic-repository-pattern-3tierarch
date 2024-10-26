
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using simple_api_generic_repo.BLL.GenericBase;
using simple_api_generic_repo.BLL.Services;
using simple_api_generic_repo.BLL.SpecificServicesInterface;
using simple_api_generic_repo.DAL.Data;
using simple_api_generic_repo.DAL.GenericBase;
using simple_api_generic_repo.DAL.Repositories;
using simple_api_generic_repo.DAL.SpecificRepositoryInterface;
using simple_api_generic_repo.Profiles;
using System;

namespace simple_api_generic_repo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConStr")));
            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepositoryAsync<>));
            builder.Services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
            builder.Services.AddScoped<IEmployeeRepositroy, EmployeeRepository>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            builder.Services.AddScoped<IDepartmentService, DepartmentService>();
            builder.Services.AddAutoMapper(typeof(MyMappingProfile));


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
