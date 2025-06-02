using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlGastosBlazor.Components.Entities
{
    public class Gasto
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int FondoMonetarioId { get; set; }
        public string Observaciones { get; set; } = string.Empty;
        public string Comercio { get; set; } = string.Empty;
        public string TipoDocumento { get; set; } = string.Empty;

        public int UsuarioId { get; set; } = 0;

        [ForeignKey("FondoMonetarioId")]
        public FondoMonetario? Fondo { get; set; }
        public ICollection<GastoDetalle> Detalles { get; set; } = new List<GastoDetalle>();
    }

}
