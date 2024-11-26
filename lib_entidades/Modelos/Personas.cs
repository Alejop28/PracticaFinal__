using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Personas
    {
        [Key] public int Id { get; set; }
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }
        public int Tipo { get; set; }
        public string? Imagen { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }

        [ForeignKey("Tipo")] public Tipos? _Tipo { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Cedula) ||
                string.IsNullOrEmpty(Nombre) ||
                Tipo <= 0)
                return false;
            return true;
        }
    }
}