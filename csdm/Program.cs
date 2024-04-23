
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using csdm.Data;

namespace csdm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //builder.Services.AddDbContext<csdmContext>(options =>
            //    options.UseSqlServer(builder.Configuration.GetConnectionString("csdmContext") ?? throw new InvalidOperationException("Connection string 'csdmContext' not found.")));
            
            if (builder.Environment.IsDevelopment())
            {
                builder.Services.AddDbContext<csdmContext>(options =>
                options.UseSqlServer(builder.Configuration["DEV_DB"] ?? throw new InvalidOperationException("Dev connection string 'DEV_DB' not found.")));
            }

            if (builder.Environment.IsProduction())
            {
                IConfigurationRoot config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.Production.json", optional: false)
                    .AddUserSecrets<Program>()
                    .Build();
                builder.Services.AddDbContext<csdmContext>(options =>
                options.UseSqlServer(config["PROD_DB"] ?? throw new InvalidOperationException("Prod connection string 'PROD_DB' not found.")));
            }
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.Configure<FormOptions>(options =>
            {
                options.MultipartBodyLengthLimit = 300000000;
            });

            var app = builder.Build();
            
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            if (app.Environment.IsProduction())
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
