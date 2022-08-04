using Exchange.DataAccess;
using System.Reflection;
using MediatR;
using Exchange.Application.Handlers.Queries;
using Exchange.Contract.Request.Query;

namespace Exchange.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<AppDbContext>();
            builder.Services.AddOptions();
            builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

            builder.Services.AddMediatR(Assembly.Load("Exchange.Application"));
            builder.Services.AddMediatR(Assembly.Load("Exchange.Contract"));

            var app = builder.Build();

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