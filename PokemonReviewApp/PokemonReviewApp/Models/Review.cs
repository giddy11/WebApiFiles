namespace PokemonReviewApp.Models
{
    public class Review : BaseEntity
    {
        public virtual string? Name { get; set; }
        public virtual string? Text { get; set; }
        public virtual Reviewer? Reviewer { get; set; }
        public virtual Pokemon? Pokemon { get; set; }
    }
}
