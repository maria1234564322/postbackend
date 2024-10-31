using System.Collections.Generic;
using Application.Dto;
using Application.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Web.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        private readonly IIndexService _indexService;

        public IndexController(IIndexService indexService)
        {
            _indexService = indexService;
        }


        [HttpGet("search")]
        public ActionResult<IEnumerable<IndexDto>> Search([FromQuery] string district, [FromQuery] string region, [FromQuery] string city, [FromQuery] string street, [FromQuery] string numberStreet)
        {
            var indices = _indexService.Search(district, region, city, street, numberStreet);
            return Ok(indices);
        }


        [HttpGet()]
        public ActionResult<IndexDto> Get(int id)
        {
            var index = _indexService.Get(id);
            if (index == null)
            {
                return NotFound();
            }
            return Ok(index);
        }

        [HttpGet("all")]
        public ActionResult<List<IndexDto>> GetAll()
        {
            var indexDtos = _indexService.GetAll();
            return Ok(indexDtos);
        }

        [HttpPost]
        public ActionResult Create([FromBody] CreateIndexDto index)
        {
            _indexService.Create(index);
            return Ok();
        }

        [HttpPut()]
        public ActionResult Update([FromBody] IndexDto index)
        {
            if (index == null)
            {
                return BadRequest("Invalid index data.");
            }

            _indexService.Update(index);
            return NoContent();


        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var index = _indexService.Get(id);
            if (index == null)
            {
                return NotFound();
            }

            _indexService.Delete(id);
            return NoContent();
        }


        [HttpPost("find")]
        public ActionResult<int> FindIndex([FromBody] FindIndexDto index)
        {
            try
            {
                int result = _indexService.FindIndex(index);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
