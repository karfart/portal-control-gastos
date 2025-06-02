using System.ComponentModel.DataAnnotations.Schema;

namespace ControlGastosBlazor.Components.Entities
{
    public class Presupuesto
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; } = 0;
        public int TipoGastoId { get; set; }
        public int Mes { get; set; } // 1-12
        public int Anio { get; set; }
        public decimal Monto { get; set; }

        [ForeignKey("TipoGastoId")]
        public TipoGasto? TipoGasto { get; set; }
    }

}
