namespace CarRent.Car.Infrastructure.Persistence
{

    using CarRent.Car.Domain;

    using Microsoft.EntityFrameworkCore;

    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public CarContext(DbContextOptions<CarContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(
                x => {
                    x.HasKey(y => y.Id);
                    x.HasIndex(y => y.CarNumber);
                    x.HasOne(y => y.CarClass);
                    x.HasOne(y => y.Brand);
                    x.HasOne(y => y.Type);
                }
            );

            modelBuilder.Entity<CarClass>(
               x => {
                   x.HasKey(y => y.Id);
               }
            );

            modelBuilder.Entity<Brand>(
               x => {
                   x.HasKey(y => y.Id);
               }
            );

            modelBuilder.Entity<Type>(
               x => {
                   x.HasKey(y => y.Id);
               }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
