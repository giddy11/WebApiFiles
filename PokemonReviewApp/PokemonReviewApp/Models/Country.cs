namespace PokemonReviewApp.Models
{
    public class Country : BaseEntity
    {
        public virtual string? Name { get; set; }
        public virtual List<Owner>? PokemonOwners { get; set; }
    }
}
