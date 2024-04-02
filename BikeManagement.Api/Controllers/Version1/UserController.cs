using Asp.Versioning;
using BikeManagement.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BikeManagement.Api.Controllers.Version1
{
    [ApiVersion("1.0")]
    [Route("/bike/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        //[MapToApiVersion("2.0")]  // Map hàm tới phiên bản mới nhất được cập nhật
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            return Ok();
        }
    }
}
