using Microsoft.EntityFrameworkCore;

namespace DOTNETMicros.Precipitation.DataAccess;

public class PrecipDbContext : DbContext  {
public PrecipDbContext()
{
    
}

public PrecipDbContext(DbContextOptions opts): base(opts){

}
public DbSet<Precipitation>? precipitation {get;set;}
 


protected override void OnModelCreating(ModelBuilder modelBuilder){
    base.OnModelCreating(modelBuilder);
    SnakeCaseIdentityTableNames(modelBuilder);
}

protected static void SnakeCaseIdentityTableNames(ModelBuilder modelBuilder){
    modelBuilder.Entity<Precipitation>(

        b=>{
            b.ToTable("precipitation");
        }
    );
}


protected override void OnConfiguring(DbContextOptionsBuilder options)=>
    options.UseSqlServer($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=precipDb;Data Source=.\\sqlexpress");
 
 
 
}



 
