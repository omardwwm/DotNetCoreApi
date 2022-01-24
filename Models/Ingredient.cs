namespace AspNetProjetFinal.Models
{
    public class Ingredient
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Unity { get; set; }


        // Navigation properties
        public ICollection<Recipe>? Recipes { get; set; }
        

    }
}
