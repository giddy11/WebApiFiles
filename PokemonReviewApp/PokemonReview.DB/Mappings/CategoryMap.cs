using PokemonReviewApp.Models;

namespace PokemonReview.DB.Mappings
{
    public class CategoryMap : BaseEntityMap<Category>
    {
        public CategoryMap()
        {
            Map(category => category.Name);
        }
    }
}
