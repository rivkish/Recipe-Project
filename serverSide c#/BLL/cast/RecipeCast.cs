using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;
namespace BLL.cast
{
    public class RecipeCast
    {
        public RecipeDTO GetRecipeDTO(Recipe recipe)
        {
            RecipeDTO RecipeDTO = new RecipeDTO();
            RecipeDTO.Id = recipe.Id;
            RecipeDTO.Name = recipe.Name;
            RecipeDTO.PreparationTimeInMinute = recipe.PreparationTimeInMinute;
            RecipeDTO.Level = recipe.Level;
            RecipeDTO.AddDate = recipe.AddDate;
            RecipeDTO.Preparation = recipe.Preparation;
            RecipeDTO.Image = recipe.Image;
            RecipeDTO.IsDisplay = recipe.IsDisplay;
            RecipeDTO.UserId = recipe.UserId;
            RecipeDTO.CategoryId = recipe.CategoryId;
            RecipeDTO.Layers = new List<LayerDTO>();
            recipe.Layers.ForEach(a => RecipeDTO.Layers.Add(LayerCast.GetLayerDTO(a)));
            return RecipeDTO;
        }
        public Recipe GetRecipe(RecipeDTO recipeDTO)
        {
            
            Recipe Recipe = new Recipe();

            Recipe.Id = recipeDTO.Id;
            Recipe.Name = recipeDTO.Name;
            Recipe.PreparationTimeInMinute = recipeDTO.PreparationTimeInMinute;
            Recipe.Level = recipeDTO.Level;
            Recipe.AddDate = recipeDTO.AddDate;
            Recipe.Preparation = String.Join("#", recipeDTO.Preparation);
            Recipe.Image = recipeDTO.Image;
            Recipe.IsDisplay = recipeDTO.IsDisplay;
            Recipe.UserId = recipeDTO.UserId;
            Recipe.CategoryId = recipeDTO.CategoryId;
            Recipe.Layers = new List<Layer>();
            recipeDTO.Layers.ForEach(a => Recipe.Layers.Add(LayerCast.GetLayer(a)));
            return Recipe;

        }

    }
}
