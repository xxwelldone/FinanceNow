using FinanceNow.Data;
using FinanceNow.Entities.DTO;
using FinanceNow.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinanceNow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        private readonly FinanceNowContext financeNowContext;
 

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;

        }
        [HttpPost("register")]
        public async Task<ActionResult<UsuarioResponseDTO>> Create(UsuarioCreateDTO usuarioCreateDTO)
        {
            try
            {
                UsuarioResponseDTO usuarioResponseDTO = await _usuarioService.CreateAsync(usuarioCreateDTO);
                return Ok(usuarioResponseDTO);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("Login")]
        public async Task<ActionResult<UsuarioLoggedDTO>> Login(UsuarioLoginDTO loginDTO)
        {
            try
            {
                UsuarioLoggedDTO user = await _usuarioService.LoginAsync(loginDTO);
                return Ok(user);
            }
            catch (Exception ex) { 
                return BadRequest(ex.Message);
            }
        }
       
        
    }
}
