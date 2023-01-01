using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
namespace BLL
{
    public class RecipeBL
    {
        
         private projectDb db;
        public RecipeBL(RecipeCast recipeCast)
        {
            this.db = db;
         }

        public List<RecipeDTO> GetRecipes()
        {
            List<RecipeDTO> recipeDTO = new List<RecipeDTO>();
            List<Recipe> recipes = db.Recipes.ToLits();
            foreach (Recipe item in recipes)
            {
                recipeDTO.Add(cast.RecipeCast.GetRecipeDTO(item));
            }
            return recipeDTO;

        }
        public RecipeDTO GetRecipe(int id)
        {
            return cast.RecipeCast.GetRecipeDTO(db.Recipes.Find(id));
        }

        public List<RecipeDTO> GetRecipesByCategoryId(int categoryId)
        {
            List<Recipe> recipes= db.Recipes.Where(p => p.CategoryId == categoryId).ToList();
            List<RecipeDTO> recipeDTO = new List<RecipeDTO>();
            foreach (Recipe item in recipes)
            {
                recipeDTO.Add(cast.RecipeCast.GetRecipeDTO(item));
            }
            return recipeDTO;
        }
    }

    internal class List<T>
    {
    }
}

