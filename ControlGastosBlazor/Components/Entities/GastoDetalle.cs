using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlGastosBlazor.Components.Entities
{
    public class GastoDetalle
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int GastoId { get; set; }
        [Required]
        public int TipoGastoId{ get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Monto { get; set; }

        [ForeignKey("TipoGastoId")]
        public TipoGasto? TipoGasto { get; set; }

        [ForeignKey("GastoId")]
        public Gasto? Gasto { get; set; }
    }

}
