using BSESAPI_CRUD.Data;
using BSESAPI_CRUD.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BSESAPI_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BSESAPIController : ControllerBase
    {
        private readonly DbContextClass _dbcontext;
        public BSESAPIController(DbContextClass dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<ConsumerInfromation>>> GetInformation()
        {
            if (_dbcontext.ConsumerInformations == null)
            {
                return NotFound();
            }

            return Ok(await _dbcontext.ConsumerInformations.ToListAsync());

        }

        [HttpGet("{id}")]

        public async Task<ActionResult<ConsumerInfromation>> GetInformationbyId(int id)
        {
            if (_dbcontext.ConsumerInformations == null)
            {
                return NotFound();
            }

            var brand = await _dbcontext.ConsumerInformations.FindAsync(id);

            if (brand == null)
            {
                return NotFound();
            }

            return Ok(brand);
        }

        [HttpPost]

        public async Task<ActionResult<ConsumerInfromation>> CreateInformation(ConsumerInfromation info)
        {

            _dbcontext.ConsumerInformations.Add(info);
            await _dbcontext.SaveChangesAsync();


            return CreatedAtAction(nameof(GetInformation), new { id = info.Id }, info);
        }

        
     }
}
