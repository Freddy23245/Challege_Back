using ClienteChallenge.Interfaces;
using ClienteChallenge.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ClienteChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var ClientesGetAll = await _clienteService.GetAll();
            return Ok(ClientesGetAll);
        }
        [HttpGet("Get")]
        public async Task<IActionResult> Get(int id)
        {
            var ClienteGet = await _clienteService.Get(id);
            return Ok(ClienteGet);
        }
        [HttpGet("Search")]
        public async Task<IActionResult> Search(string Name)
        {
            var ClientePorNombre = await _clienteService.Search(Name);
            return Ok(ClientePorNombre);
        }
        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(Cliente cliente)
        {
           await _clienteService.Insert(cliente);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(Cliente cliente)
        {
            await _clienteService.Update(cliente);
            return Ok();
        }
    }
}
