using BasarSoftProject1_API.DTOs;
using BasarSoftProject1_API.Entities;
using BasarSoftProject1_API.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasarSoftProject1_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapsController : ControllerBase
    {
        //private readonly IRepository<LocationAndUser> _repository;
        private readonly IRepository<LocAndUser> _repository;

        //public MapsController(IRepository<LocationAndUser> repository)
        public MapsController(IRepository<LocAndUser> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> ListLocation()
        {
            var values = await _repository.GetAllAsync();
            return Ok(values);
        }

        [HttpGet("LocationById/{id}")]
        public async Task<IActionResult> LocationById(int id)
        {
            var value=await _repository.GetByIdAsync(id);
            return Ok(value);
        }


        [HttpPost]
        public async Task<IActionResult> CreateMap(LocAndUser locAndUser)
        {
            await _repository.CreateAsync(locAndUser);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var value = await _repository.GetByIdAsync(id);
            await _repository.RemoveAsync(value);
            return Ok();
        }

    }
}
