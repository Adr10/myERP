namespace myERP.Core.models
{
    public class PeliculaViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        
        public ICollection<GeneroViewModel> Generos { get; set; }
        public ICollection<CineViewModel> Cines { get; set; }
        public ICollection<ActorViewModel> Actores { get; set; }
    }
}
