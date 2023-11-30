using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PCBuilder.Domain.Entities;
using PCBuilder.DTO;
using PCBuilder.Service.Interfaces;

namespace PCBuilder.Controllers
{
    [Route("api/PC")]
    [ApiController]
    public class PCController : ControllerBase
    {
        private readonly IPCService _service;

        public PCController(IPCService service)
        {
            _service = service;
        }

        [HttpPost]
        [ProducesResponseType(204, Type = typeof(PCDto))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CreatePC([FromBody] PCDto pc)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _service.Create(pc);
            return Ok();
        }
    }
}
