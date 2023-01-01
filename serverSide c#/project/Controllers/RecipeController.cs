using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DTO;
using BLL;
using BLL.cast;
using Microsoft.AspNetCore.Cors;
namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("myProject")]
    public class RecipeController : ControllerBase
    {
        private readonly projectDb1 db;
       private RecipeBl recipeBl;

        public RecipeController(projectDb1 p, RecipeBl recipeBl)
        {
            db = p;
            this.recipeBl = recipeBl;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(RecipeDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetRecipeById(int id)
        {
            Recipe r = db.Recipes.Find(id);
            if (r == null)
            {
                return NotFound();
            }
            return Ok(RecipeCast.GetRecipeDTO(r));
        }

        [HttpGet]
        public IEnumerable<RecipeDTO> GetAllRecipes()
        {
            return recipeBl.GetRecipes();
        }

        [HttpPost("AddRecipe")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public IActionResult AddRecipe([FromBody] RecipeDTO rDTO)
        {
            if (rDTO == null)
                return BadRequest();
            Recipe r = db.Recipes.Find(rDTO.Id);
            if(r !=null)
                return Conflict();
            Recipe newR = RecipeCast.GetRecipe(rDTO);
            db.Recipes.Add(newR); 
            db.SaveChanges();
            return CreatedAtAction(nameof(AddRecipe), RecipeCast.GetRecipeDTO(newR)); 
        }
        [HttpPut("UpdateRecipe/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]

        public IActionResult UpdateRecipe(int id,RecipeDTO rDTO)
        {
            if (rDTO == null)
                return BadRequest();
            if (rDTO.Id != id)
                return Conflict();
            db.Entry(RecipeCast.GetRecipe(rDTO)).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
          db.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]

        public IActionResult RemoveRecipe(int id)
        {
            Recipe r = db.Recipes.Find(id);
            if (r == null)
            {
                return NotFound();
            }
            db.Recipes.Remove(id);
            db.SaveChanges();
            return NoContent();
        }

        [HttpGet]
        public IEnumerable<RecipeDTO> GetRecipesByCategoryId(int categoryId)
        {
            return recipeBl.GetRecipesByCategoryId(categoryId);
        }



    }
}
