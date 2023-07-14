using BusinessLogic;
using Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductLogic _logic;
        public ProductController(IProductLogic logic)
        {
            _logic = logic;
        }

        [HttpGet("GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            try
            {
                var product = _logic.GetProducts();
                if(product != null)
                {
                    return Ok(product);
                }
                else
                {
                    return BadRequest("No Products Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetProductById/{id}")]
        public IActionResult GetProduct([FromRoute]int id)
        {
            try
            {
                var product = _logic.GetProductById(id);
                if(product != null)
                {
                    return Ok(product);
                }
                else
                {
                    return BadRequest("No Products Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteProduct")]
        public IActionResult DeleteProduct([FromQuery]int id)
        {
            try
            {
                var product = _logic.DeleteProduct(id);
                if(product != null)
                {
                    return Ok(product);
                }
                else
                {
                    return BadRequest("No Products Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddProduct")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            try
            {
                var newproduct = _logic.AddProduct(product);
                return Created("Added", product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct([FromQuery]int id,Product product)
        {
            try
            {
                var updateproduct = _logic.UpdateProduct(id, product);
                if(updateproduct != null)
                {
                    return Ok(updateproduct);
                }
                else
                {
                    return BadRequest("No Products Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
