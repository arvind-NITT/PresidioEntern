using Microsoft.EntityFrameworkCore;
using PizzaShopAPI.context;
using PizzaShopAPI.interfaces;
using PizzaShopAPI.models;
using PizzaShopAPI.Repositories;
using PizzaShopAPI.Service;

namespace PizzaShopAPI
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

            #region Context
            /* builder.Services.AddDbContext<PizzaShopContext>(
                 options => options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection"))
             );*/
            builder.Services.AddDbContext<PizzaShopContext>();
            //builder.Services.AddDbContext<PizzaShopContext>();
            #endregion
            #region Repository
            builder.Services.AddScoped<IRepository<int, Customer>, CustomerRepository>();
            builder.Services.AddScoped<IRepository<int, UserCredential>, UserCredentialRepository>();
            #endregion

            #region EmployeeBL
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<IPizzaService, PizzaService>();
            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
