using AutoMapper;
using myERP.Core.Entities;
using myERP.Core.models;

namespace myERP.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() {
            CreateMap<Actor, ActorViewModel>();
            CreateMap<Actor, ActorUpdatemodel>();

            CreateMap<Cine, CineViewModel>()
                .ForMember(m => m.Latitud, e => e.MapFrom(prop => prop.Ubicacion.Y))
                .ForMember(m => m.Longitud, e => e.MapFrom(prop => prop.Ubicacion.X));


            CreateMap<Genero, GeneroViewModel>();
            CreateMap<Pelicula, PeliculaViewModel>()
                .ForMember(x => x.Cines,
                        z => z.MapFrom(prop => prop.SalaDeCines.Select(x => x.cine)))
                .ForMember(x => x.Actores,
                        z => z.MapFrom(prop => prop.ActorPelicula.Select(x => x.Actor)));




        }

        

    }
}
