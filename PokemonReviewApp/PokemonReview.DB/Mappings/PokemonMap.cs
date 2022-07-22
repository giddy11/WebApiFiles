using PokemonReviewApp.Models;

namespace PokemonReview.DB.Mappings
{
    public class PokemonMap : BaseEntityMap<Pokemon>
    {
        public PokemonMap()
        {
            Map(pokemon => pokemon.Name);
            Map(pokemon => pokemon.BirthDate);
            HasMany(pokemon => pokemon.Reviews);
            HasManyToMany(pokemon => pokemon.PokemonOwners);
            HasMany(pokemon => pokemon.PokemonCategories);
        }
    }
}
