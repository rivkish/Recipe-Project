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
    public class CategoryController : ControllerBase
    {
        projectDb1 db;
        CategoryBl categoryBl;
        public CategoryController(projectDb1 p, CategoryBl categoryBl)
        {
            db = p;
            this.categoryBl = categoryBl;   
        }
        [HttpGet]
        public IEnumerable<CategoryDTO> GetAllCategories()
        {
            return categoryBl.GetCategories();
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CategoryDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetCategoryById(int id)
        {
            Category g = db.Categories.Find(id);
            if (g == null)
            {
                return NotFound();
            }
            return Ok(CategoryCast.GetCategoryDTO(g));
        }
    }
}
