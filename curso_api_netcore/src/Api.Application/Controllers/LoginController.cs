using System.Net;
using System;
using Microsoft.AspNetCore.Mvc;
using Api.Domain.Interfaces.Services.User;
using System.Threading.Tasks;
using Api.Domain.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost]
        public async Task<Object> Login([FromBody] LoginDto loginDto, [FromServices] ILoginService service)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            
            if(loginDto == null)
                return BadRequest();
            
            try
            {
                var result = await service.FindByLogin(loginDto);

                if(result != null)
                    return Ok(result);
                else
                    return NotFound();                
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
