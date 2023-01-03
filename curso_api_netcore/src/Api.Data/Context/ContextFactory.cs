using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usado para criar as migrações
            // var connectionString = "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=1234";

            var connectionStringServer = "Server=DESKTOP-N4S8L6T;Initial Catalog=DBApi;MultipleActiveResultSets=true;User ID=root;Password=1234";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            // optionsBuilder.UseMySql(connectionString);
            optionsBuilder.UseSqlServer(connectionStringServer);
            
            return new MyContext(optionsBuilder.Options);
        }
    }
}
