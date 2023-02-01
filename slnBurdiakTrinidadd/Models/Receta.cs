using slnBurdiakTrinidad.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace slnBurdiakTrinidad.Models
{
    public class Receta
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        [CheckCategoriaAttribute]
        public string Categoria { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Ingredientes { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Instrucciones { get; set; }

        [Required]
        public string NombreAutor { get; set; }

        [Required]
        public string ApellidoAutor { get; set; }

        [CheckEdadAttribute]
        public int EdadAutor { get; set; }

        [Required(ErrorMessage ="Campo obligatorio")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string EmailAutor { get; set; }
    }
}
