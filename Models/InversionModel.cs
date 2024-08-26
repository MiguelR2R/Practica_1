namespace PC1.Models
{
    public class InversionModel
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public DateTime FechaOperacion { get; set; }
        public bool SeleccionSP500 { get; set; }
        public bool SeleccionDowJones { get; set; }
        public bool SeleccionBonosUS { get; set; }
        public decimal Total { get; set; }
        public decimal IGV { get; set; }
        public decimal Comision { get; set; }
        public decimal MontoAPagar { get; set; }
        public decimal Dinero { get; set; }
    }
}
