using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Tag
  {
    public Tag()
    {
      this.JoinEntities = new HashSet<RecipeTag>();
    }

    public int TagId { get; set;}
    public string TagName { get; set;}

    public virtual ApplicationUser User { get; set; }

    public virtual ICollection<RecipeTag> JoinEntities { get;}

  }
}