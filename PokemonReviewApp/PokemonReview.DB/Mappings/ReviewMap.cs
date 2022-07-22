using PokemonReviewApp.Models;

namespace PokemonReview.DB.Mappings
{
    public class ReviewMap : BaseEntityMap<Review>
    {
        public ReviewMap()
        {
            Map(review => review.Name);
            Map(review => review.Text);
            References(review => review.Reviewer);
            References(review => review.Pokemon);
        }
    }
}
