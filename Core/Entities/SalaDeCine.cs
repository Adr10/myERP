using myERP.Core.Enums;
using System.Collections.ObjectModel;

namespace myERP.Core.Entities
{
    public class SalaDeCine : DbAudit
    {
        public int Id { get; set; }

        //[Precision(precision: 9, scale: 3)]
        public decimal Precio { get; set; }

        public TipoSalaDeCine TipoSalaDeCine { get; set; }

        public int CineId { get; set; }

        #region propiedades de la relacion

        public virtual Cine cine  { get; set; }
        public virtual Collection<Pelicula> Peliculas { get; set; }

        #endregion propiedades de la relacion

    }
}
