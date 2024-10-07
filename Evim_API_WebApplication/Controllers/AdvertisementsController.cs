using Evim_API_WebApplication.Entities;
using Evim_API_WebApplication.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Evim_API_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertisementsController : ControllerBase
    {
        private readonly IAdvertisementRepository _advrepo;

        public AdvertisementsController(IAdvertisementRepository advrepo)
        {
            _advrepo = advrepo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = await _advrepo.GetAllAsync();
            return Ok(list);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            var advr = await _advrepo.GetByIdAsync(id);
            if (advr == null)
            {
                return NotFound(id);
            }
            return Ok(advr);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Advertisement advertisement)
        {
            var addedAdvr = await _advrepo.CreateAsync(advertisement);
            return Created(string.Empty, addedAdvr);

        }


        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Advertisement advertisement)
        {
            var entity = await _advrepo.GetByIdAsync(advertisement.AdvertisementId);
            if (entity == null)
            {
                return NotFound(advertisement.AdvertisementId);
            }
            await _advrepo.UpdateAsync(advertisement);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await _advrepo.GetByIdAsync(id);
            if (entity == null)
            {
                return NotFound(id);
            }
            await _advrepo.DeleteAsync(entity);
            return NoContent();

        }
    }
}
