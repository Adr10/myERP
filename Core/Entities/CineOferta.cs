namespace myERP.Core.Entities
{
    public class CineOferta: DbAudit
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal PorcentajeDescuento { get; set; }

        public int CineId { get; set; }

       //propiedades de navegacion
        public virtual  Cine cine  { get; set; }
    }
}
