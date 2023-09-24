namespace BookStoreApp.API.Models.Author
{
    public class AuthorReadOnlyDto : BaseDto
    {
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
    }
}
