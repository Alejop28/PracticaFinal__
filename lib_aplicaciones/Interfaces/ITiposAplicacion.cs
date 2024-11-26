using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface ITiposAplicacion
    {
        void Configurar(string string_conexion);
        List<Tipos> Buscar(Tipos entidad, string tipo);
        List<Tipos> Listar();
        Tipos Guardar(Tipos entidad);
        Tipos Modificar(Tipos entidad);
        Tipos Borrar(Tipos entidad);
    }
}