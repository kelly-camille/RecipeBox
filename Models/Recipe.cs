using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public Recipe()
    {
      this.JoinEntities = new HashSet<RecipeTag>();
    }

    public int RecipeId { get; set; }
    public string RecipeName { get; set; }
    public string Instructions { get; set; }
    public string Ingredients { get; set; }
    public int Rating { get; set; }
    public virtual ApplicationUser User { get; set; }


    public virtual ICollection<RecipeTag> JoinEntities { get; set; }
  }
}