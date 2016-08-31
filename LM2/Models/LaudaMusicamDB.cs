using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace LaudaMusicam.Models
{
    public class LaudaMusicamDB : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<LaudaMusicam.Models.LaudaMusicamContext>());

        public DbSet<UserModel> Users { get; set; }

        public DbSet<RoleModel> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().ToTable("Users");
            modelBuilder.Entity<RoleModel>().ToTable("Roles");

            modelBuilder.Entity<UserModel>().HasMany(user => user.Roles).WithMany(role => role.Users);

            base.OnModelCreating(modelBuilder);
        }
    }
}
