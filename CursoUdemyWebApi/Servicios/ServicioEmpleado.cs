namespace CursoUdemyWebApi.Servicios
{
    public class ServicioEmpleado : IServicioEmpleado
    {

        //Creamos una lista de empleados de manera provisional
        private readonly List<Empleado> listaEmpleados = new()
        {
            new Empleado
            {
                Id= 1,
                Nombre = "Juan",
                CodEmpleado ="A001",
                Edad =45,
                Email = "V@hotmail.com",
                FechaAlta = DateTime.Now
            },
            new Empleado
            {
                Id= 1,
                Nombre = "Pedro",
                CodEmpleado ="A010",
                Edad =35,
                Email = "h@hotmail.com",
                FechaAlta = DateTime.Now
            },
            new Empleado
            {
                Id= 1,
                Nombre = "Manolo",
                CodEmpleado ="A017",
                Edad =17,
                Email = "y@hotmail.com",
                FechaAlta = DateTime.Now
            },
            new Empleado
            {
                Id= 1,
                Nombre = "Ana",
                CodEmpleado ="A071",
                Edad =25,
                Email = "R@hotmail.com",
                FechaAlta = DateTime.Now
            }
        };

        /// <summary>
        /// Devuelve una lista de empleados
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Empleado> DameEmpleados()
        {
           return listaEmpleados;
        }

        /// <summary>
        /// Devuelve un empleado buscado por su codigo
        /// </summary>
        /// <param name="codEmpleado">codigo de empleado</param>
        /// <returns></returns>
        public Empleado DameEmpleado(string codEmpleado)
        {
            return listaEmpleados.Where(e => e.CodEmpleado == codEmpleado).SingleOrDefault();
        }

    }
}
