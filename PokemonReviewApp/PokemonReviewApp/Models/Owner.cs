namespace PokemonReviewApp.Models
{
    public class Owner : BaseEntity
    {
        public virtual string? Name { get; set; }
        public virtual string? Gym { get; set; }
        public virtual Country? Country { get; set; }
    }
}
