using System.ComponentModel.DataAnnotations;

namespace ControlGastosBlazor.Components.Entities
{
    public class TipoGasto
    {
        [Key]
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; } = string.Empty;
    }

}
