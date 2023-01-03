namespace CursoUdemyWebApi.Servicios
{
    public interface IServicioEmpleado
    {
        //Devuelve lista de empleados
        public IEnumerable<Empleado> DameEmpleados();
    }
}
