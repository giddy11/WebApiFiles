using PokemonReviewApp.Models;

namespace PokemonReview.DB.Mappings
{
    public class OwnerMap : BaseEntityMap<Owner>
    {
        public OwnerMap()
        {
            Map(owner => owner.Name);
            Map(owner => owner.Gym);
            References(owner => owner.Country);
        }
    }
}
