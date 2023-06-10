using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RealStateApi.Data;
using System.Security.Claims;

namespace RealStateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertiesController : ControllerBase
    {

        ApiDbContext _dbContext = new ApiDbContext();

        [HttpPost]
        [Authorize]

        public IActionResult Post([FromBody] Property property)
        {
            if (property == null)
            {
            return NoContent();
            }
            else
            {
                var userEmail = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email );
            }
            return Ok();

        }
    }
}
