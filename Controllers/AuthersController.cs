using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_Authers.Data.Services;
using My_Books.Data.ViewModels;

namespace My_Authers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthersController : ControllerBase
    {
        private readonly AutherService _Autherservice;
        public AuthersController(AutherService Autherservice)
        {
            _Autherservice = Autherservice;
        }
        [HttpPost("Add-Auther")]
        public IActionResult AddAuther(AutherVM autherVM)
        {
            _Autherservice.AddAuther(autherVM);
            return Ok();
        }
        [HttpGet("Get-Authers")]
        public IActionResult GetAllAuthers()
        {
            var Authers= _Autherservice.GetAuthers();
            return Ok(Authers);
        }
        [HttpGet("Get-Auther_BY_Id/{id}")]
        public IActionResult GetAutherById(int id)
        {
            var Authers = _Autherservice.GetAutherById(id);
            return Ok(Authers);
        }
        [HttpPut("Update-Auther/{id}")]
        public IActionResult UpdateAuther(int id, AutherVM AutherVM)
        {
            var Auther = _Autherservice.UpdateAuther(id,AutherVM);
            return Ok(Auther);
        }
        [HttpDelete("Delete-Auther/{id}")]
        public IActionResult DeleteAuther(int id)
        {
            var Auther = _Autherservice.DeleteAutherById(id);
            return Ok(Auther);
        }
    }
}
