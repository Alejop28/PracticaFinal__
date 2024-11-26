using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface ITiposRepositorio
    {
        void Configurar(string string_conexion);
        List<Tipos> Listar();
        List<Tipos> Buscar(Expression<Func<Tipos, bool>> condiciones);
        Tipos Guardar(Tipos entidad);
        Tipos Modificar(Tipos entidad);
        Tipos Borrar(Tipos entidad);
    }
}