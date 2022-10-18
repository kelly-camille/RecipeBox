using Microsoft.AspNetCore.Identity;

namespace RecipeBox.Models
{
    public class ApplicationUser : IdentityUser
    {
    public int ContactId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    }
}