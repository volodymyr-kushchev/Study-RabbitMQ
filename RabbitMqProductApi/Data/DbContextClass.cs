using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RabbitMqProductApi.Models;

namespace RabbitMqProductApi.Data
{
    public class DbContextClass: DbContext
    {
        protected readonly IConfiguration _configuration;

        public DbContextClass(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Product> Products { get; set; }
    }
}
