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
        private readonly IRepository<LocationAndUser> _repository;

        public MapsController(IRepository<LocationAndUser> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Baglantı basarılıdır.");
        }

        [HttpPost]
        public async Task<IActionResult> CreateMap(LocationAndUser locationAndUser)
        {
            await _repository.CreateAsync(locationAndUser);
            return Ok();
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAllLocationAndUser()
        //{
        //    var values = await _repository.GetAllAsync();
        //    return Ok(values.Select(x=>new LocationAndUser
        //    {
        //        ID = x.ID,
        //        //Latitude = x.Latitude,
        //        //Longitude = x.Longitude,
        //        UserName=x.UserName,
        //        GeoJson=x.GeoJson,
        //    }).ToList());
        //}
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetByIdLocationAndUser(int id)
        //{
        //    var value = await _repository.GetByIdAsync(id);
        //    return Ok(new LocationAndUser
        //    {
        //        ID = value.ID,
        //        Latitude = value.Latitude,
        //        Longitude = value.Longitude,
        //        UserName = value.UserName,
        //    });
        //}
        //[HttpPost]
        //public async Task<IActionResult> CreateAsync(CreateLocationAndUser locationAndUsers)
        //{
        //    await _repository.CreateAsync(new LocationAndUser
        //    {
        //        UserName = locationAndUsers.UserName,
        //        Latitude = locationAndUsers.Latitude,
        //        Longitude = locationAndUsers.Longitude
        //    });
        //    return Ok("Kaydınız Başarıyla Eklenmiştir");
        //}
        //[HttpPut]
        //public async Task<IActionResult> UpdateAsync(LocationAndUser locationAndUsers)
        //{
        //    var value = await _repository.GetByIdAsync(locationAndUsers.ID);
        //    value.Longitude = locationAndUsers.Longitude;
        //    value.Latitude = locationAndUsers.Latitude;
        //    value.UserName = locationAndUsers.UserName;
        //    await _repository.UpdateAsync(value);
        //    return Ok("Kaydınız Başarıyla Güncellenmiştir.");
        //}
        //[HttpDelete]
        //public async Task<IActionResult> RemoveAsync(int id)
        //{
        //    var value = await _repository.GetByIdAsync(id);
        //    await _repository.RemoveAsync(value);
        //    return Ok("Kaydınız Başarıyla Silinmiştir.");
        //}
    }
}



//coordinates: Array[3909874.7977859727, 4912728.608887487]
//​
//name: ""
//​
//type: "Point"