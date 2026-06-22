using HydrahajoAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HydrahajoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HydrahajoControllers : ControllerBase
    {
        HydrahajoDBContext dbContext = new HydrahajoDBContext();

        [HttpPost]
        public ActionResult AddNewComponent([FromBody] AddComponentDTO dto_model)
        {
            // Implementation for POST request
            try
            {
                var ComponentEgyed = new Component
                {
                    Component_Name = dto_model.Component_Name,
                    Component_type = dto_model.Component_type
                };

                dbContext.components.Add(ComponentEgyed);
                dbContext.SaveChanges();

                return StatusCode(StatusCodes.Status201Created, "Component added successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while adding the component.");
            }
        }
    }
}
