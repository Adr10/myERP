using Microsoft.VisualBasic;
using System.Collections.ObjectModel;

namespace myERP.Core.Entities
{
    public class Pelicula: DbAudit
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public Boolean EnCartelera { get; set; }
        public DateTime FechaEstreno { get; set; }
        public string PosterURL { get; set; }


        #region propiedades de navegacion
        public virtual Collection<Genero> Generos { get; set; }
        public virtual Collection<SalaDeCine>  SalaDeCines { get; set; }

        public virtual Collection<ActorPelicula> ActorPelicula { get; set; }
        # endregion propiedades de navegacion
        public Pelicula()
        {
        }
    }
}
