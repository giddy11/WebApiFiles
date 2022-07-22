using PokemonReviewApp.Models;

namespace PokemonReview.DB.Mappings
{
    public class ReviewerMap : BaseEntityMap<Reviewer>
    {
        public ReviewerMap()
        {
            Map(reviewer => reviewer.FirstName);
            Map(reviewer => reviewer.LastName);
            HasMany(reviewer => reviewer.Reviews);
        }
    }
}
