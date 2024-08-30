using CRUD_Entityframework.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Entityframework.Controllers
{
    [Route("api/currencies")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public CurrencyController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllCurrencies()
        {
            //var res = _appDbContext.tblCurrency.ToList();
            var res = await (from currenries in _appDbContext.tblCurrency
                             select currenries).ToListAsync();
            return Ok(res);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GeByIdCurrencies([FromRoute] int id)
        {
            //var res = _appDbContext.tblCurrency.FindAsync(id);
            var res = await (from c in _appDbContext.tblCurrency
                             where c.Id == id  // Replace Id with the actual column name of the primary key
                             select c).FirstOrDefaultAsync();
            return Ok(res);
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GeByNameCurrencies([FromRoute] string name)
        {
           //var res = _appDbContext.tblCurrency.Where(x=>x.Title == name).FirstOrDefaultAsync();    
            var res = await (from c in _appDbContext.tblCurrency
                             where c.Title == name  // Replace Id with the actual column name of the primary key
                             select c).FirstOrDefaultAsync();
            return Ok(res);
        }

    }
}
