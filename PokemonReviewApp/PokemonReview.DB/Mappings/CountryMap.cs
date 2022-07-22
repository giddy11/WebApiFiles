using PokemonReviewApp.Models;

namespace PokemonReview.DB.Mappings
{
    public class CountryMap : BaseEntityMap<Country>
    {
        public CountryMap()
        {
            Map(country => country.Name);
            HasMany(country => country.PokemonOwners);
        }
    }
}
