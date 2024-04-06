using Microsoft.AspNetCore.Mvc;
using Web_APi_crud.Interfaces;
using Web_APi_crud.Models;

namespace Web_APi_crud.Controllers
{
    public class GrupoController : Controller
    {
       private readonly IGrupo _grupo;
        public GrupoController(IGrupo grupo)
        {
            _grupo = grupo;
        }
        [HttpGet("api/Grupos")]
        public IActionResult Grupos()
        {
            return Ok(_grupo.AllGrupos());
        }
        [HttpGet("api/Grupo/{id}")]
        public IActionResult ConsultarGrupo(int id)
        {
            return Ok(_grupo.ConsultarGrupo(id));
        }
        [HttpPost("api/AgregarGrupo")]
        public IActionResult AgregarGrupo([FromBody] Grupo grupo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_grupo.AgregarGrupo(grupo));
        }

        [HttpPut("api/Grupo/{id}")]
        public IActionResult ActualizarGrupo(int id, [FromBody] Grupo grupo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_grupo.ActualizarGrupo(id, grupo));
        }

        [HttpDelete("api/Grupo/{id}")]
        public IActionResult EliminarGrupo(int id)
        {
            return Ok(_grupo.EliminarGrupo(id));
        }
    }
}
