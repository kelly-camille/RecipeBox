using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;
using System.Collections.Generic;
using System.Linq;

namespace RecipeBox.Controllers
{
  [Authorize]
  public class RecipesController : Controller
  {
    private readonly RecipeBoxContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public RecipesController(UserManager<ApplicationUser> userManager, RecipeBoxContext db)
    {
      _userManager = userManager;
      _db = db;
    }
    public async Task<ActionResult> Index()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      var userRecipes = _db.Recipes.Where(entry => entry.User.Id == currentUser.Id).ToList();
      var sortedRating = userRecipes.OrderByDescending(recipe => recipe.Rating).ToList();
      ViewBag.RecipeId = new SelectList(_db.Recipes, "RecipeId", "Ingredients");
      return View(sortedRating);
    }
    public ActionResult Create()
    {
      ViewBag.TagId = new SelectList(_db.Tags, "TagId", "TagName");
      return View();
    }
    [HttpPost]
    public async Task<ActionResult> Create(Recipe recipe, int TagId)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      recipe.User = currentUser;
      _db.Recipes.Add(recipe);
      _db.SaveChanges();
      if (TagId != 0)
      {
        _db.RecipeTag.Add(new RecipeTag() { TagId = TagId, RecipeId = recipe.RecipeId});
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      var thisRecipe = _db.Recipes
        .Include(recipe => recipe.JoinEntities)
        .ThenInclude(join => join.Tag)
        .FirstOrDefault(recipe => recipe.RecipeId == id);
      return View(thisRecipe);
    }
    public ActionResult Edit(int id)
    {
      var thisRecipe = _db.Recipes.FirstOrDefault(recipe => recipe.RecipeId == id);
      ViewBag.TagId = new SelectList(_db.Tags, "TagId", "TagName");
      return View(thisRecipe);
    }
    [HttpPost]
    public ActionResult Edit(Recipe recipe, int TagId)
    {
      if (TagId != 0)
      {
        _db.RecipeTag.Add(new RecipeTag() { TagId = TagId, RecipeId = recipe.RecipeId});
      }
      _db.Entry(recipe).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult AddTag(int id)
    {
      var thisRecipe = _db.Recipes.FirstOrDefault(recipe => recipe.RecipeId == id);
      ViewBag.TagId = new SelectList(_db.Tags, "TagId", "Name");
      return View(thisRecipe);
    }

    [HttpPost]
    public ActionResult AddTag(Recipe recipe, int TagId)
    {
      if (TagId != 0)
      {
        _db.RecipeTag.Add(new RecipeTag() { TagId = TagId, RecipeId = recipe.RecipeId});
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      var thisRecipe = _db.Recipes.FirstOrDefault(recipe => recipe.RecipeId == id);
      return View(thisRecipe);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisRecipe = _db.Recipes.FirstOrDefault(recipe => recipe.RecipeId == id);
      _db.Recipes.Remove(thisRecipe);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteTag(int joinId)
    {
      var joinEntry = _db.RecipeTag.FirstOrDefault(entry => entry.RecipeTagId == joinId);
      _db.RecipeTag.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public async Task<ActionResult> ShowSearch()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      var userRecipes = _db.Recipes.Where(entry => entry.User.Id == currentUser.Id).ToList();
      ViewBag.RecipeId = new SelectList(_db.Recipes, "RecipeId", "Ingredients");
      return View(userRecipes);
    }
    [HttpPost]
    public ActionResult ShowSearch(string search)
    {
      List<Recipe> model = _db.Recipes.Where(recipe => recipe.Ingredients.ToLower().Contains(search.ToLower())).ToList();
      return View("ShowSearch", model);
    }
  }
}
