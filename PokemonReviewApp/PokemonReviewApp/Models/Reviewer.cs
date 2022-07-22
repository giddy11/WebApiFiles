namespace PokemonReviewApp.Models
{
    public class Reviewer : BaseEntity
    {
        public virtual string? FirstName { get; set; }
        public virtual string? LastName { get; set; }
        public virtual List<Review>? Reviews { get; set; }
    }
}
