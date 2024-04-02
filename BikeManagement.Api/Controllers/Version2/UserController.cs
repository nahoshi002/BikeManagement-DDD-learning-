using Asp.Versioning;
using BikeManagement.Domain.Models;
using BikeManagement.Domain.Models.UserManagements.Users;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BikeManagement.Api.Controllers.Version2
{
    [ApiVersion("2.0")]
    [Route("/bike/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            return Ok();
        }
    }
}
