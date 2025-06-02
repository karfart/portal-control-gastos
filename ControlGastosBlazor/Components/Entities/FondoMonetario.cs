namespace ControlGastosBlazor.Components.Entities
{
    public class FondoMonetario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty; // "Cuenta Bancaria" o "Caja Menuda"
    }

}
