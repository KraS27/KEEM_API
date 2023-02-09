using KEEM_DAL;
using KEEM_DAL.Interfaces;
using KEEM_DAL.Repositories;
using KEEM_Models.Tables;
using KEEM_Service.Implementations;
using KEEM_Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KEEM_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            var connection = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 25))));

            builder.Services.AddCors();

            builder.Services.AddControllers();
            
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IBaseRepository<Poi>, PoiRepository>();
            builder.Services.AddScoped<IPoiService, PoiService>();


            var app = builder.Build();

            app.UseCors(b => b.AllowAnyOrigin());

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