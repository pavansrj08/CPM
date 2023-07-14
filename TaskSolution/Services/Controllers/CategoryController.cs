using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryLogic _logic;
        public CategoryController(ICategoryLogic logic)
        {
            _logic = logic;
        }

        [HttpGet("GetCategoryById")]
        public IActionResult GetCategoryById([FromQuery]int id) 
        {
            try
            {
                var category = _logic.GetCategoryById(id);
                if(category != null)
                {
                    return Ok(category);
                }
                else
                {
                    return BadRequest("No Categories Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetCategoryByName")]
        public IActionResult GetCategoryByName([FromQuery] string name)
        {
            try
            {
                var category = _logic.GetCategoryByName(name);
                if (category != null)
                {
                    return Ok(category);
                }
                else
                {
                    return BadRequest("No Categories Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAllCategories")]
        public IActionResult GetAllCategories()
        {
            try
            {
                var category = _logic.GetCategories();
                if(category !=null)
                {
                    return Ok(category);
                }
                else
                {
                    return BadRequest("No Categories Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddCategory")]
        public IActionResult AddCategory([FromBody] Category category)
        {
            try
            {
                var newcategory = _logic.AddCategory(category);
                return Created("Added", category);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteCategory")]
        public IActionResult DeleteCategory([FromQuery]int id)
        {
            try
            {
                var category = _logic.DeleteCategory(id);
                if (category != null)
                {
                    return Ok(category);
                }
                else
                {
                    return BadRequest("No Categories Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut("UpdateCategory")]
        public IActionResult UpdateCategory([FromQuery] int id,Category category)
        {
            try
            {
                var updatecategory = _logic.UpdateCategory(id,category);
                if(updatecategory != null)
                {
                    return Ok(updatecategory);
                }
                else
                {
                    return BadRequest("No Categories Found");
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
