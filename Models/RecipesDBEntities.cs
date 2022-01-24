using Microsoft.EntityFrameworkCore;

namespace AspNetProjetFinal.Models
{
    public class RecipesDBEntities :DbContext
    {
        public RecipesDBEntities(DbContextOptions<RecipesDBEntities> options) : base(options)
        {
            // to test
            ChangeTracker.LazyLoadingEnabled = false;
        }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<IngredientRecipe>()
            //    .HasKey(ir => new { ir.RecipeId, ir.IngredientId });

            //builder.Entity<IngredientRecipe>()
            //    .HasOne(ir => ir.Recipe)
            //    .WithMany(i => i.IngredientRecipes)
            //    .HasForeignKey(ir => ir.RecipeId);
            ////.IsRequired();

            //builder.Entity<IngredientRecipe>()
            //    .HasOne(ir => ir.Ingredient)
            //    .WithMany(r => r.IngredientRecipes)
            //    .HasForeignKey(ir => ir.IngredientId);
            ////.IsRequired();

            // A revoir!!!!
            //builder.Entity<User>(entity => {
            //    entity.HasIndex(e => e.Email).IsUnique();
            //});


            builder.Entity<Recipe>()
                .HasOne(r => r.User)
                .WithMany(u => u.Recipes)
                .HasForeignKey(r => r.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);


            builder.Entity<Comment>().HasKey(c => new { c.RecipeId, c.UserId });

            builder.Entity<Comment>()
                .HasOne(u => u.User)
                .WithMany(c => c.Comments)
                .HasForeignKey(u => u.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Comment>()
                .HasOne(r => r.Recipe)
                .WithMany(c => c.Comments)
                .HasForeignKey(r => r.RecipeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        //public DbSet<IngredientRecipe> IngredientRecipes { get; set; }

    }
}
