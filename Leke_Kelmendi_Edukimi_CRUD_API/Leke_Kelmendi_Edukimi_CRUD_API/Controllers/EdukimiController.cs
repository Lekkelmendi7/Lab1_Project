using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Leke_Kelmendi_Edukimi_CRUD_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EdukimiController : ControllerBase
    {
        private readonly DataContext context;

        public EdukimiController(DataContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Edukimi>>> Get()
        {
            return Ok(await context.Edukimi.ToListAsync());
        }
        [HttpGet("{ID}")]
        public async Task<ActionResult<Edukimi>> Get(int ID)
        {
            var edukimi = await context.Edukimi.FindAsync(ID);
            if (edukimi == null)
                return BadRequest("Puntori nuk u gjet!");
            return Ok(edukimi);
        }

        [HttpPost]
        public async Task<ActionResult<List<Edukimi>>> AddEdukimi(Edukimi edukimi)
        {
            context.Edukimi.Add(edukimi);
            await context.SaveChangesAsync();
            return Ok(await context.Edukimi.ToListAsync());

        }

        [HttpPut]

        public async Task<ActionResult<List<Edukimi>>> UpdateEdukimi(Edukimi request)
        {
            var dbEdukimi = await context.Edukimi.FindAsync(request.ID_Puntori);
            if (dbEdukimi == null)
                return BadRequest("Puntori nuk u gjet!");

            dbEdukimi.Emri_Puntorit = request.Emri_Puntorit;
            dbEdukimi.Mbiemri_Puntorit = request.Mbiemri_Puntorit;
            dbEdukimi.Kolegji = request.Kolegji;
            dbEdukimi.VitiMbarimit_Studimit = request.VitiMbarimit_Studimit;
            dbEdukimi.Niveli_Studimit = request.Niveli_Studimit;
            await context.SaveChangesAsync();

            return Ok(await context.Edukimi.ToListAsync());
        }

        [HttpDelete("{ID}")]

        public async Task<ActionResult<List<Edukimi>>> Delete(int ID)
        {
            var dbEdukimi = await context.Edukimi.FindAsync(ID);
            if (dbEdukimi == null)
                return BadRequest("Puntori nuk u gjet!");

            context.Edukimi.Remove(dbEdukimi);
            await context.SaveChangesAsync();


            return Ok(await context.Edukimi.ToListAsync());
        }


    }
}
