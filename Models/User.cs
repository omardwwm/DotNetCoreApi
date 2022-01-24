using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AspNetProjetFinal.Models
{
    //[Index(nameof(Email), IsUnique =true) ] // a revoir
    public class User
    {
        public string Id { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool IsProfessional { get; set; }

        public string Picture { get; set; }

        public ICollection<Recipe>? Recipes { get; set; }

        public ICollection<Comment>? Comments { get; set; }


    }
}
