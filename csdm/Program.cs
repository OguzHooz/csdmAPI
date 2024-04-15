
using Microsoft.AspNetCore.Http.Features;
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using csdm.Data;
=======
>>>>>>> 67c149afad9ee6d6098bf3aa8807f134344ac229

namespace csdm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
<<<<<<< HEAD
            builder.Services.AddDbContext<csdmContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("csdmContext") ?? throw new InvalidOperationException("Connection string 'csdmContext' not found.")));
=======
>>>>>>> 67c149afad9ee6d6098bf3aa8807f134344ac229

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

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
