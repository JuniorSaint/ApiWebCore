using System;
using System.Threading.Tasks;
using Api.Domain.Dtos.City;
using Api.Domain.Interfaces.Services.City;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private ICityService _service { get; set; }
        public CitiesController(ICityService service)
        {
            _service = service;
        }

        [Authorize("Bearer")]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);

            }

        }

        [Authorize("Bearer")]
        [HttpGet]
        [Route("{id}", Name = "GetCityWithId")]
        public async Task<ActionResult> Get(Guid id)
        {
            try
            {
                var result = await _service.Get(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpGet]
        [Route("byId/{id}")]
        public async Task<ActionResult> GetCompleteById(Guid id)
        {
            try
            {
                var result = await _service.GetCompleteById(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpGet]
        [Route("{codeIBGE}")]
        public async Task<ActionResult> Get(int codeIBGE)
        {
            try
            {
                var result = await _service.GetCompleteByIBGE(codeIBGE);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CityDtoCreate cityDto)
        {
            try
            {
                var result = await _service.Post(cityDto);
                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetCityWithId", new { id = result.Id })), result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode((int) System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [Authorize("Bearer")]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] CityDtoUpdate cityDto)
        {
            try
            {
                var result = await _service.Put(cityDto);
                if (result != null)
                {
                    return Ok (result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
