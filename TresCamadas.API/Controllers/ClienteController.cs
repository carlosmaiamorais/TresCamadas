using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TresCamadas.BLL;
using TresCamadas.Model;

namespace TresCamadas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly ClienteService _clienteService;

        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public IActionResult GetClientes()
        {
            var listaClientes = _clienteService.ObterTodos();
            return Ok(listaClientes);
        }

        [HttpPost]
        public IActionResult CadastrarCliente([FromBody] Cliente param)
        {
            try
            {
                _clienteService.CadastrarCliente(param);
                return Ok("Cliente cadastrado com sucesso"); //return 200                
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro ao cadastrar Cliente. ERRO: " + ex.Message); //return 400
            }
           
        }

        [HttpPut]
        public IActionResult AtualizarCliente([FromBody] Cliente param)
        {
            try
            {
                _clienteService.AtualizarCliente(param);
                return Ok("Cliente atualizado com sucesso");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro ao Atualizar Cliente. ERRO: " + ex.Message); //return 400
            }            
        }

        [HttpDelete]
        public IActionResult ExcluirCliente(long id)
        {
            try
            {
                _clienteService.ExcluirCliente(id);
                return Ok("Cliente excluído com sucesso");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro ao excluir Cliente. ERRO: " + ex.Message); //return 400
            }           
            
        }
        
    }
}
