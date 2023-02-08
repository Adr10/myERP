
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace myERP.Core.Entities
{
    public class Genero: DbAudit
    {
        //[Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        [Required]
        public bool estaBorrado { get; set; }

        //public Genero(int generoId, string nombre)
        //{
        //    GeneroId = generoId;
        //    Nombre = nombre;
        //}

        #region propiedades de navegacion
        public virtual Collection<Pelicula> Peliculas { get; set; }

        # endregion propiedades de navegacion

        public Genero()
        {
        }
    }
}
