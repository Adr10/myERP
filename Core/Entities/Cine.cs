using NetTopologySuite.Geometries;
using System.Collections.ObjectModel;

namespace myERP.Core.Entities
{
    public class Cine : DbAudit
    {
        public int cineId { get; set; }
        public string Nombre { get; set; }

        public Point Ubicacion { get; set; }

        #region propiedades de navegacion

        public virtual CineOferta CineOferta { get; set; }

        public virtual  Collection<SalaDeCine> SalasDeCine { get; set; }


        #endregion propiedades de navegacion

        public Cine()
        {
        }
    }
}
