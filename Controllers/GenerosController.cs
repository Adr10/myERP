using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using myERP.Core.Entities;
using myERP.Data.contexts;

namespace MyErp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerosController : ControllerBase
    {

        private readonly MyDbContext _context;

        public GenerosController(MyDbContext context)
        {
            _context = context;        
        }

        [HttpGet]
        public async Task <IEnumerable<Genero>> Get()
        {

            //var generos = _context.Generos.AsTracking().ToList();

            //var aux = _context.Generos;
            //var aux2 = _context.Generos.ToList();

            return await _context.Generos
                //.Where(x=> x.estaBorrado==false)
                //.ignoreQueryFilters
                .ToArrayAsync();
        }


        [HttpGet("primer")]
        public async Task<ActionResult<Genero>> Primer()
        {
            //return await _context.Generos.FirstAsync();
            
            //return await _context.Generos.FirstAsync(genero => genero.Nombre.StartsWith("C"));
            var result =  await _context.Generos.FirstAsync(genero => genero.Nombre.StartsWith("Z"));

            if (result is null)
            {
                return NotFound();
            }
            else {
                return result;
            }

            //return (result is null) ? NotFound() : result;

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Genero>> Primer(int id)
        {
            var result = await _context.Generos.FirstOrDefaultAsync(genero => genero.Id == id);

            if (result is null)
            {
                return NotFound();
            }
            else
            {
                return result;
            }
        }


        [HttpGet("filtrar")]
        public async Task<IEnumerable<Genero>> Filtrar()
        {
            return await _context.Generos.Where(genero => genero.Nombre.StartsWith("A") || genero.Nombre.StartsWith("Z"))
                .ToArrayAsync();

           
        }

        [HttpGet("filtrarporparametro")]
        public async Task<IEnumerable<Genero>> Obtener(string? param)
        {
            return await _context.Generos.Where(genero => genero.Nombre.Contains(param))
                .OrderBy(genero => genero.Nombre)
                .ThenByDescending(genero => genero.Id)
                .ToArrayAsync();


            //var auxLq = from generos in _context.Generos
            //            where
            //            generos.Nombre.Contains(param)
            //            orderby generos.Nombre
            //            select generos;


            var resultado2 = _context.Generos
                .Where(genero => genero.Nombre.Contains(param))
                .OrderBy(genero => genero.Nombre)
                .ThenByDescending(genero => genero.Id)
                .ToList();



        }


        [HttpGet("paginacion")]
        public async Task <ActionResult<IEnumerable<Genero>>> GetPaginacion() {

            
            var result = await _context.Generos
                        //el numero de registros que me voy a saltar 
                        .Skip(1)
                        //el numero de registros a recuperar
                        .Take(2)
                        .ToListAsync();

            return result;
        }

        [HttpGet("paginacionCompleja")]
        public async Task<ActionResult<IEnumerable<Genero>>> GetPaginacionCompleja(int pagina)
        {
            
            var skip = (pagina - 1) * 3;

            var result = await _context.Generos
                        .OrderBy(genero => genero.Id)
                        //el numero de registros que me voy a saltar 
                        .Skip(skip)
                        //el numero de registros a recuperar
                        .Take(3)
                        .ToListAsync();

            return result;
        }



        [HttpPost("paginacion")]
        public async Task<ActionResult> Post(Genero genero) {


            var status1 = _context.Entry(genero).State;

            genero.UpdateAt = DateTime.UtcNow;

            _context.Generos.Add(genero);

            var status2 = _context.Entry(genero).State;

            await _context.SaveChangesAsync();

            var status3 = _context.Entry(genero).State;

            return Ok();

        }


        [HttpPost("varios")]
        public async Task<ActionResult> Post(Genero[] generos)
        {

            //genero.UpdateAt = DateTime.UtcNow;

            _context.Generos.AddRange(generos);
         
            await _context.SaveChangesAsync();

            return Ok();

        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id,[FromBody]Genero genero) {

            var generoBD = _context.Generos
                .AsTracking()
                .FirstOrDefault(x => x.Id == id);

            if (generoBD is null)
            {
                return NotFound();
            }
            else {
                if (genero.Nombre != null)
                {

                    generoBD.Nombre = genero.Nombre;

                }
                //_context.Generos.Update(generoBD); esto si es no tracking 
                await _context.SaveChangesAsync();

                return Ok();
            }

        

        }


        [HttpDelete("borradoLogico/{id:int}")]
        public async Task<ActionResult> DeleteLogico(int id)
        {
            var generoBD = _context.Generos
                .AsTracking()
                .FirstOrDefault(x => x.Id == id);

            if (generoBD is null)
            {
                return NotFound();
            }

            generoBD.estaBorrado = true;

            await _context.SaveChangesAsync();

            return Ok();

        }

    }   
}
