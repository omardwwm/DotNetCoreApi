using System.ComponentModel.DataAnnotations;

namespace AspNetProjetFinal.Models
{
    public class Comment
    {
        [Key]
        public string Id { get; set; }

        public string Content { get; set; }

        public DateTime CreationDate { get; set; }

        public string RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

    }
}
