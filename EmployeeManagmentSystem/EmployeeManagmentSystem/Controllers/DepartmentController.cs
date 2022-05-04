using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly DataContext context;

        public DepartmentController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<Departamenti>>> Get()
        {
            return Ok(await context.Departmentet.ToListAsync());
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Departamenti>> Get(int id)
        {
            var kompani = await context.Departmentet.FindAsync(id);
            if (kompani == null)
                return BadRequest("Kompanija nuk u gjet");
            return Ok(kompani);
        }

        [HttpPost]

        public async Task<ActionResult<List<Departamenti>>> AddCompany(Departamenti kompani)
        {
            context.Departmentet.Add(kompani);
            await context.SaveChangesAsync();   

            return Ok(await context.Departmentet.ToListAsync());  
        }

        [HttpPut]

        public async Task<ActionResult<List<Departamenti>>> UpdateKompani(Departamenti request)
        {
            var dbKompani = await context.Departmentet.FindAsync(request.Id);
            if (dbKompani == null)
                return BadRequest("Kompanija nuk u gjet");

            dbKompani.Company = request.Company;
            dbKompani.Department = request.Department;

            await context.SaveChangesAsync();
            return Ok(await context.Departmentet.ToListAsync());
        }

        [HttpDelete("{id}")] 

        public async Task<ActionResult<List<Departamenti>>> Delete(int id)
        {
            var dbKompani = await context.Departmentet.FindAsync(id);
            if (dbKompani == null)
                return BadRequest("Kompanija nuk u gjet");

            context.Departmentet.Remove(dbKompani);
            await context.SaveChangesAsync();

            return Ok(await context.Departmentet.ToListAsync());
        }

    }
}
