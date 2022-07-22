using System.ComponentModel.DataAnnotations;

namespace ApiDemo.Models
{
    public class UserModel
    {
        //Adding some Data validation
        [Required]
        [MinLength(length: 10)]
        public string FirstName { get; set; }

    }
}
