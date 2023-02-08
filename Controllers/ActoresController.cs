using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using myERP.Core.Entities;
using myERP.Core.models;
using myERP.Data.contexts;

namespace myERP.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ActoresController : ControllerBase
    {
        private readonly MyDbContext _context;
        private readonly IMapper _mapper;

        public ActoresController(MyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ActorViewModel>> Get()
        {

            // var result = await _context.Actores
            //     .Select(prop => new ActorViewModel()
            //{
            //    Id = prop.Id,
            //    Nombre = prop.Nombre

            //}).ToListAsync();
            // return result;


            //var result = await _context.Actores
            //    .Select(prop => new ActorViewModel()
            //    {
            //        Id = prop.Id,
            //        Nombre = prop.Nombre

            //    }).ToListAsync();
            //return result;

            var parcial = await _context.Actores.ToListAsync();
            var result = _mapper.Map<List<ActorViewModel>>(parcial);

            return result;
        }

        //var generos = _context.Generos.AsTracking().ToList();

        //var aux = _context.Generos;
        //var aux2 = _context.Generos.ToList();


        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] ActorUpdatemodel ActorUpdatemodel)
        {

            var actorBD = _context.Actores
                .AsTracking()
                .FirstOrDefault(x => x.Id == id);

            if (actorBD is null)
            {
                return NotFound();
            }
            else
            {
                if (ActorUpdatemodel.Nombre != null)
                {

                    actorBD.Nombre = ActorUpdatemodel.Nombre;

                }
                if (ActorUpdatemodel.Biografia != null)
                {

                    actorBD.Biografia = ActorUpdatemodel.Biografia;
                }
                if (ActorUpdatemodel.FechaNacimiento != null)
                {
                    actorBD.FechaNacimiento = ActorUpdatemodel.FechaNacimiento;
                }

            }


            //esta forma es como lo de arriba pero mas corto
            //actorBD = _mapper.Map<Actor>(ActorUpdatemodel);

            //_context.Generos.Update(generoBD); esto si es no tracking 
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var actorBD = _context.Actores
                .AsTracking()
                .FirstOrDefault(x => x.Id == id);

            _context.Actores.Remove(actorBD);

            await _context.SaveChangesAsync();

            return Ok();

        }

        
    }
}
