using System;
using System.Threading.Tasks;
using Api.Domain.Dtos.City;
using Api.Domain.Dtos.CodeZip;
using Api.Domain.Interfaces.Services.City;
using Api.Domain.Interfaces.Services.CodeZip;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodeZipesController : ControllerBase
    {
        private ICodeZipService _service { get; set; }
        public CodeZipesController(ICodeZipService service)
        {
            _service = service;
        }


        [Authorize("Bearer")]
        [HttpGet]
        [Route("{id}", Name = "GetCodeZipWithId")]
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

        [AllowAnonymous]
        [HttpGet]
        [Route("{zipCode}")]
        public async Task<ActionResult> Get(string zipCode)
        {
            try
            {
                var result = await _service.Get(zipCode);
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
        public async Task<ActionResult> Post([FromBody]  CodeZipDtoCreate zipCode)
        {
            try
            {
                var result = await _service.Post(zipCode);
                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetCodeZipWithId", new { id = result.Id })), result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [Authorize("Bearer")]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] CodeZipDtoUpdate zipCode)
        {
            try
            {
                var result = await _service.Put(zipCode);
                if (result == null)
                {
                    return BadRequest();
                }              
                    return Ok(result);                   
                
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
