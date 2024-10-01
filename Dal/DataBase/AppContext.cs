using Dal.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dal.DataBase;

public class AppContext : IdentityDbContext<User, Role, int>
{
    public AppContext(DbContextOptions<AppContext> options) : base(options)
    {
    }

//"Data Source=185.165.118.72,1433;Initial Catalog=Develop;User ID=key1;Password=7Dwuv15@;Trust Server Certificate=True"
//"Data Source=DESKTOP-M202FR8\KEY1;Initial Catalog=Parsme;Integrated Security=True;Trust Server Certificate=True"
    public AppContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=185.165.118.72;Initial Catalog=NewPars;User ID=pars;Password=I$w225am;Trust Server Certificate=True"
        );
        base.OnConfiguring(optionsBuilder);
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<Brand>().HasQueryFilter(x => !x.IsDelete);

        //modelBuilder.Entity<Brand>().HasQueryFilter(x => !x.IsDelete);
        //modelBuilder.Entity<UserAddress>().HasQueryFilter(x => !x.IsDelete);
        //modelBuilder.Entity<Category>().HasQueryFilter(x => !x.IsDelete );
        //modelBuilder.Entity<CategoryDetail>().HasQueryFilter(x => !x.IsDelete );
        //modelBuilder.Entity<Color>().HasQueryFilter(x => !x.IsDelete);
        //modelBuilder.Entity<DiscountCode>().HasQueryFilter(x => !x.IsDelete);
        //modelBuilder.Entity<Feature>().HasQueryFilter(x => !x.IsDelete );
        //modelBuilder.Entity<Guarantee>().HasQueryFilter(x => !x.IsDelete);
        //modelBuilder.Entity<ImageGallery>().HasQueryFilter(x => !x.IsDelete);
        //modelBuilder.Entity<Product>().HasQueryFilter(x => !x.IsDelete );
        //modelBuilder.Entity<ProductColor>().HasQueryFilter(x => !x.IsDelete);
        //modelBuilder.Entity<ProductDetail>().HasQueryFilter(x => !x.IsDelete);
        //modelBuilder.Entity<SubCategory>().HasQueryFilter(x => !x.IsDelete );
        //modelBuilder.Entity<State>().HasQueryFilter(x => !x.IsDelete);
        //modelBuilder.Entity<City>().HasQueryFilter(x => !x.IsDelete);

        base.OnModelCreating(modelBuilder);
    }
}