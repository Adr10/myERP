using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using myERP.Core.Entities;
using myERP.Core.models;
using myERP.Data.contexts;
using NetTopologySuite;
using NetTopologySuite.Geometries;
using System.Collections.ObjectModel;

namespace myERP.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CinesController : ControllerBase
    {

        private readonly MyDbContext _context;
        private readonly IMapper _mapper;

        public CinesController(MyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CineViewModel>> Get()
        {
            var result = await _context.Cines.ProjectTo<CineViewModel>(_mapper.ConfigurationProvider).ToListAsync(); 

            return result;
        }

        [HttpGet("cercanos")]
        public async Task<ActionResult> GetCercanos(double latitud, double longitud)
        {
            var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);

            var miUbicacion = geometryFactory.CreatePoint(new Coordinate( longitud, latitud));

            // latitud: 18.483272
            // longitud: -69.940143
            var distanciaMax = 2000;

            var cines = await _context.Cines
                    .OrderBy(x => x.Ubicacion.Distance(miUbicacion))
                    .Where(x => x.Ubicacion.IsWithinDistance(miUbicacion, distanciaMax))
                    .Select(x => new
                    { 
                    Nombre = x.Nombre,
                    Distancia = Math.Round(x.Ubicacion.Distance(miUbicacion))
                    }).ToListAsync();

            return Ok(cines);

        }



        [HttpPost]
        public async Task<ActionResult> Post()
        {

            var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);

            var miUbicacion = geometryFactory.CreatePoint(new Coordinate(-69.940143, 18.483272));


            var cine = new Cine()
            {

                Nombre = "mi nuevo cine",
                Ubicacion = miUbicacion,
                CineOferta = new CineOferta() { 
                PorcentajeDescuento = 5,
                FechaInicio= DateTime.Today,
                FechaFin = DateTime.Today.AddDays(7)
                },
                SalasDeCine= new Collection<SalaDeCine>
                { 
                    new SalaDeCine(){ 
                        Precio=200,
                        TipoSalaDeCine = Core.Enums.TipoSalaDeCine.DosDimensiones
                    },
                    new SalaDeCine(){
                        Precio=350,
                        TipoSalaDeCine = Core.Enums.TipoSalaDeCine.TresDimensiones
                    }   
                }
            };

            _context.Cines.AddRange(cine);

            await _context.SaveChangesAsync();

            return Ok();
        }



    }
}
