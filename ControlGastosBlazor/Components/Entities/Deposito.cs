using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlGastosBlazor.Components.Entities
{
    public class Deposito
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public DateTime Fecha { get; set; }
        
        [Required]
        public int FondoMonetarioId { get; set; }
        
        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Monto { get; set; }

        public int UsuarioId { get; set; }

        [ForeignKey("FondoMonetarioId")]
        public FondoMonetario? Fondo { get; set; }
    }

}
