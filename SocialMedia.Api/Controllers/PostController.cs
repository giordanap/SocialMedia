using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpGet]
        // Metodo publico en la clase que retornara un IActionResult
        public IActionResult GetPosts()
        {
            // Devuelve un status 200
            return Ok(null);
        }
    }
}
