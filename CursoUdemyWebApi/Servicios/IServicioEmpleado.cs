namespace CursoUdemyWebApi.Servicios
{
    public interface IServicioEmpleado
    {
        /// <summary>
        /// Devuelve una lista de empleados
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Empleado> DameEmpleados();

        /// <summary>
        /// Devuelve un empleado
        /// </summary>
        /// <param name="codEmpleado">codigo empleado</param>
        /// <returns></returns>
        public Empleado DameEmpleado(string codEmpleado);
    }
}
