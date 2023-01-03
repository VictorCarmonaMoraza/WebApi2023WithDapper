using CursoUdemyWebApi.DTO;

namespace CursoUdemyWebApi.MapeosDTO
{
    public static class MapEmpleado
    {
        public static EmpleadoDTO convertirDTO(this Empleado empleado)
        {
            if(empleado !=null)
            {
                return new EmpleadoDTO
                {
                    Nombre = empleado.Nombre,
                    CodEmpleado = empleado.CodEmpleado,
                    Email = empleado.Email,
                    Edad = empleado.Edad,
                };
            }
            return null;
        }
            
    }
}
