using System;
using System.Threading.Tasks;
using Api.Domain.Interfaces.Services.CodeZip;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Api.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodeZipesController
    {
        public ICodeZipService _service { get; set; }
        public CodeZipesController(ICodeZipService service)
        {
            _service = service;
        }




    }
}
