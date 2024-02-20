using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SistemaGestion.Database;
using SistemaGestion.Services;

namespace SistemaGestion
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
            //Inyectamos los servicios para poder usar estos dentro de los controllers
            builder.Services.AddScoped<UsuarioService>();
            builder.Services.AddScoped<ProductoService>();
            builder.Services.AddScoped<VentaService>();
            builder.Services.AddScoped<ProductoVendidoservice>();
            //Inyectamos el context de la base de datos
            builder.Services.AddDbContext<DataBaseContext>(options =>
            {
                options.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=CoderHouse;Trusted_Connection=True;");
            });

            // Configurar AutoMapper
            var mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<EntityToDtoProfile>());
            var mapper = mapperConfiguration.CreateMapper();

            // Registrar AutoMapper en el contenedor de servicios
            builder.Services.AddSingleton(mapper);

            // configuramos las politicas para que otro servidor externo pueda realizarle las request a esta api
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyMethod();
                    policy.AllowAnyHeader();
                    policy.AllowAnyOrigin();
                });
            });

            var app = builder.Build();

            app.UseCors();
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
