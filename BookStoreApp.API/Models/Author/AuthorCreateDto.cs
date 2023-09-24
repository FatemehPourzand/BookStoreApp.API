using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models.Author
{
    public class AuthorCreateDto
    {
        [Required]

        public string FirstName { get; set; }

        public string? Lastname { get; set; }

        public string? Bio { get; set; }
    }
}
