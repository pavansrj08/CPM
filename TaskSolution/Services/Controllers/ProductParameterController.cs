using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductParameterController : ControllerBase
    {
        IProductParameterLogic _logic;

        public ProductParameterController(IProductParameterLogic logic)
        {
            _logic = logic;
        }

        [HttpGet("GetAllProductParameters")]
        public IActionResult Get()
        {
            try
            {
                var parameter = _logic.GetProductParameters();
                if (parameter != null)
                {
                    return Ok(parameter);
                }
                else
                {
                    return BadRequest("No Product Parameters Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetProductPatameterById")]
        public IActionResult GetProductParameterById([FromQuery]int id)
        {
            try
            {
                var parameter = _logic.GetProductParameterById(id);
                if (parameter != null)
                {
                    return Ok(parameter);
                }
                else
                {
                    return BadRequest("No Product Parameters Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteProductParameter")]
        public IActionResult DeleteProductParameterById([FromQuery]int id)
        {
            try
            {
                var parameter = _logic.DeleteProductParameter(id);
                if (parameter != null)
                {
                    return Ok(parameter);
                }
                else
                {
                    return BadRequest("No Product Parameters Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddProductParameter")]
        public IActionResult AddProductParameter([FromBody]ProductParameter parameter)
        {
            try
            {
                var newparameter = _logic.AddProductParameter(parameter);
                return Created("Added", parameter);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateParameter")]
        public IActionResult UpdateProductParameter([FromQuery] int id,ProductParameter parameter)
        {
            try
            {
                var updateparameter = _logic.UpdateProductParameter(id, parameter);
                if (updateparameter != null)
                {
                    return Ok(updateparameter);
                }
                else
                {
                    return BadRequest("No Product Parameters Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
