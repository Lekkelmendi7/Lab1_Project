using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Leke_Kelmendi_Kontrata_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KontrataController : ControllerBase
    {
        private readonly DataContext context;

        public KontrataController(DataContext context)
        {
            this.context = context;
        }
       
            [HttpGet]
            public async Task<ActionResult<List<Kontrata>>> Get()
            {
                return Ok(await context.Kontrata.ToListAsync());
            }
            [HttpGet("{ID}")]
            public async Task<ActionResult<Kontrata>> Get(int ID)
            {
                var kontratat = await context.Kontrata.FindAsync(ID);
                if (kontratat == null)
                    return BadRequest("Kontrata nuk u gjet!");
                return Ok(kontratat);
            }

            [HttpPost]
            public async Task<ActionResult<List<Kontrata>>> AddKontratat(Kontrata kontratat)
            {
                context.Kontrata.Add(kontratat);
                await context.SaveChangesAsync();
                return Ok(await context.Kontrata.ToListAsync());

            }
            [HttpPut]

            public async Task<ActionResult<List<Kontrata>>> UpdateKontrata(Kontrata request)
            {
                var dbKontrata = await context.Kontrata.FindAsync(request.ID_Puntori);
                if (dbKontrata == null)
                    return BadRequest("Kontrata nuk u gjet!");

                dbKontrata.Emri_Puntorit = request.Emri_Puntorit;
                dbKontrata.Mbiemri_Puntorit = request.Mbiemri_Puntorit;
                dbKontrata.Kompania = request.Kompania;
                dbKontrata.Pozita_Punes = request.Pozita_Punes;
                dbKontrata.Pronari_Kompanise = request.Pronari_Kompanise;
                await context.SaveChangesAsync();

                return Ok(await context.Kontrata.ToListAsync());
            }

            [HttpDelete("{ID}")]

            public async Task<ActionResult<List<Kontrata>>> Delete(int ID)
            {
                var dbKontrata = await context.Kontrata.FindAsync(ID);
                if (dbKontrata == null)
                    return BadRequest("Kontrata nuk u gjet!");

                context.Kontrata.Remove(dbKontrata);
                await context.SaveChangesAsync();


                return Ok(await context.Kontrata.ToListAsync());
            }
        }

    }
