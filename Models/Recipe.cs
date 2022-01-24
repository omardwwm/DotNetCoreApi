using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetProjetFinal.Models
{
    public class Recipe
    {
        internal readonly object IngredientRecipe;

        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Instruction { get; set; }

        public int PreparationTime { get; set; }

        public int CookingTime { get; set; }

        public string Picture { get; set; }

        public DateTime CreationDate { get; set; }

        //public ICollection<IngredientRecipe> IngredientRecipes { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public string UserId { get; set; }
        public User? User { get; set; }


    }
}
