namespace PokemonReviewApp.Models
{
    public class Pokemon : BaseEntity
    {
        public virtual string? Name { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual List<Review>? Reviews { get; set; }
        public virtual List<Owner>? PokemonOwners { get; set; }
        public virtual List<Category>? PokemonCategories { get; set; }
    }
}
