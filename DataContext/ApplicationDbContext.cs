using Microsoft.EntityFrameworkCore;
using webapi_aspnet.Models;

namespace webapi_aspnet.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
        
    }
}