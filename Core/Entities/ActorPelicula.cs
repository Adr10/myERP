using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace myERP.Core.Entities
{
    public class ActorPelicula : DbAudit
    {
       
        public int PeliculaId { get; set; }
       
        public int ActorId { get; set; }
        public string Personaje { get; set; }
        public int Orden { get; set; }

        #region propiedades de navegacion
        public virtual Pelicula Pelicula  { get; set; }
        public virtual Actor Actor { get; set; }

        # endregion propiedades de navegacion
    }
}
