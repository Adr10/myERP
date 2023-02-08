using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using myERP.Core.Entities;
using myERP.Core.models;
using myERP.Data.contexts;
using System.Linq;

namespace myERP.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        private readonly MyDbContext _context;
        private readonly IMapper _mapper;

        public PeliculasController(MyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<PeliculaViewModel>> Get(int id) { 
        
        var pelicula = await _context.Peliculas
                .Include(x=>x.Generos)
                .Include(x => x.SalaDeCines)
                .ThenInclude(x=>x.cine)
                .Include(pel =>pel.ActorPelicula)
                .ThenInclude(x => x.Actor)
                .FirstOrDefaultAsync(p => p.Id == id);

        var pelicula2 = _context.Peliculas.FindAsync(id);

            if (pelicula is null)
                return NotFound();

            var result = _mapper.Map<PeliculaViewModel>(pelicula);
            result.Cines = result.Cines.DistinctBy(x => x.CineId).ToList();
            return Ok(result);


        }

        [HttpGet("agrupadasPorEstreno")]
        public async Task<ActionResult> GetAgrupadasPorEstreno()
        { 
            var result = await _context.Peliculas
                .GroupBy(x => x.EnCartelera)
                .Select(x => new
                {
                    EnCartelera = x.Key,
                    Total = x.Count(),
                    Peliculas = x.ToList()
                }).ToListAsync();
                
            return Ok(result);

        }


        [HttpGet("filtrar")]
        public async Task<ActionResult<PeliculaViewModel>> Filtrar([FromBody] PeliculaFilterModel peliculaFilterModel)
        {
            //esto puede generar una excepcion si es null 
            //if (peliculaFilterModel.EnCartelera.HasValue) {
            //    if (peliculaFilterModel.EnCartelera==true) {}
            //    if (peliculaFilterModel.EnCartelera.Value==true) {}


            var result = _context.Peliculas.AsQueryable();

            if (!string.IsNullOrEmpty(peliculaFilterModel.Titulo)) {
                result = result.Where(x => x.Titulo.Contains(peliculaFilterModel.Titulo));
            
            }
            if (peliculaFilterModel.EnCartelera.HasValue)
            {
                    result = result.Where(x => x.EnCartelera.Equals(peliculaFilterModel.EnCartelera));   
            }
            if (peliculaFilterModel.GeneroId.HasValue)
            {
                result = result.Where(x => x.Generos.Select(y => y.Id).Contains(peliculaFilterModel.GeneroId.Value));
            
            }

            if (peliculaFilterModel.ProximosEstrenos) {

                var today = DateTime.Today;
                result = result.Where(x => x.FechaEstreno > today);
            }


            var peliculas = await result
                            .Include(x => x.Generos)
                            .ToListAsync();

            return _mapper.Map<PeliculaViewModel>(peliculas);

        }

        [HttpGet("filtrar2")]
        public async Task<ActionResult<PeliculaViewModel>> Filtrar2([FromBody] PeliculaFilterModel peliculaFilterModel)
        {
            var today = DateTime.Today;

            var result = await _context.Peliculas
                .Include(x => x.Generos)
                    .Where(x => true
                    && (string.IsNullOrEmpty(peliculaFilterModel.Titulo)
                    || x.Titulo.Contains(peliculaFilterModel.Titulo))
                    && (!peliculaFilterModel.EnCartelera.HasValue)
                    || x.EnCartelera.Equals(peliculaFilterModel.EnCartelera)
                    &&(!peliculaFilterModel.ProximosEstrenos
                    || x.FechaEstreno > today)
                    &&(peliculaFilterModel.GeneroId.HasValue
                    || x.Generos.Select(y=>y.Id).Contains(peliculaFilterModel.GeneroId.Value)))
                    .ToListAsync();

            return _mapper.Map<PeliculaViewModel>(result);

        }
    }
}
