namespace myERP.Core.models
{
    public class PeliculaFilterModel
    {
        public String Titulo { get; set; }
        public int? GeneroId { get; set; }
        public bool? EnCartelera { get; set; }
        public bool ProximosEstrenos { get; set; }


    }
}
