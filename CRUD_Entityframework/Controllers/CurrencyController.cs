using CRUD_Entityframework.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetAllCurrencies()
        {
            //var res = _appDbContext.tblCurrency.ToList();
            var res = (from currenries in _appDbContext.tblCurrency
                      select currenries).ToList();
            return Ok(res);
        }

    }
}
