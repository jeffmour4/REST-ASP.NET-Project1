using Microsoft.EntityFrameworkCore;

namespace REST_ASP.NET_Project1NET8.Model.Context
{
    public class MySqlContext: DbContext
    {
        public MySqlContext() 
        {
            
        }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options){ }

        public DbSet<Person> People { get; set; }
    }
}
