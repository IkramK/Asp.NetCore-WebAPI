using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_Books.Data.ViewModels;
using My_Publishers.Data.Services;

namespace My_Publishers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private readonly PublisherService _PublisherService;
        public PublishersController(PublisherService PublisherService)
        {
            _PublisherService = PublisherService;
        }
        [HttpPost("Add-Publisher")]
        public IActionResult AddPublisher(PublisherVM publisherVM)
        {
            _PublisherService.AddPublisher(publisherVM);
            return Ok();
        }
        [HttpGet("Get-Publishers")]
        public IActionResult GetAllPublishers()
        {
            var Publishers= _PublisherService.GetPublishers();
            return Ok(Publishers);
        }
        [HttpGet("Get-Publisher_BY_Id/{id}")]
        public IActionResult GetPublisherById(int id)
        {
            var Publishers = _PublisherService.GetPublisherById(id);
            return Ok(Publishers);
        }
        [HttpPut("Update-Publisher/{id}")]
        public IActionResult UpdatePublisher(int id, PublisherVM publisherVM)
        {
            var Publisher = _PublisherService.UpdatePublisher(id,publisherVM);
            return Ok(Publisher);
        }
        [HttpDelete("Delete-Publisher/{id}")]
        public IActionResult DeletePublisher(int id)
        {
            var Publisher = _PublisherService.DeletePublisherById(id);
            return Ok(Publisher);
        }
    }
}
