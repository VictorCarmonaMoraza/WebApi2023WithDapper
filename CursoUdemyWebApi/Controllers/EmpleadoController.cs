using CursoUdemyWebApi.DTO;
using CursoUdemyWebApi.MapeosDTO;
using CursoUdemyWebApi.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CursoUdemyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly IServicioEmpleado _servicioEmpleado;

        public EmpleadoController(IServicioEmpleado servicioEmpleado)
        {
            _servicioEmpleado = servicioEmpleado;
        }

        [HttpGet]
        public IEnumerable<EmpleadoDTO> DameEmpleado()
        {
            //Convertimso cada empleado en un EmpleadoDTO
            var listaEmpleados = _servicioEmpleado.DameEmpleados().Select(e=>e.convertirDTO());
            return listaEmpleados;
        }

        [HttpGet("{codEmpleado}")]
        public  ActionResult<EmpleadoDTO> DameEmpleado(string codEmpleado)
        {
            var empleado = _servicioEmpleado.DameEmpleado(codEmpleado).convertirDTO();

            if(empleado is null)
            {
                return NotFound();
            }
            return empleado;
        }
    }
}
