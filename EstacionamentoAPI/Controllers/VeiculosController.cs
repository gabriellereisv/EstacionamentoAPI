using EstacionamentoAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EstacionamentoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        private readonly EstacionamentoRepository _estacionamentoRepository;

        public VeiculosController(EstacionamentoRepository estacionamentoRepository)
        {
            _estacionamentoRepository = estacionamentoRepository;
        }

        [HttpGet("veiculos-estacionados")]
        public async Task<IActionResult> ListagemVeiculosEstacionados()
        {
            var veiculos = await _estacionamentoRepository.ListarVeiculosEstacionados();
            return Ok(veiculos);
        }

        // GET api/<VeiculosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VeiculosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VeiculosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VeiculosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
