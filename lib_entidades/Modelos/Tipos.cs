using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Tipos
    {
        [Key] public int Id { get; set; }
        public string? Nombre { get; set; }

        [NotMapped] public virtual ICollection<Personas>? Personas { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Nombre))
                return false;
            return true;
        }
    }
}