using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myERP.Core.Entities
{
       //[Table("TablaActores")]
       //[Table("TablaActores",Schema ="peliculas")]
    public class Actor : DbAudit
    {

        public int Id { get; set; }

        public string Nombre { get; set; }


        //[Column("ColumnBiografia")]
        public String Biografia { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public Actor()
        {
        }

        #region propiedades de navegacion
        public virtual Collection<ActorPelicula> ActorPelicula { get; set; }

        # endregion propiedades de navegacion
    }
}
