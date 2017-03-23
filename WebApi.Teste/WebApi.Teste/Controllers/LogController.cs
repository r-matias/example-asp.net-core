using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Teste.Entities.Model;
using WebApi.Teste.IBusiness;

namespace WebApi.Teste.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class LogController : Controller
    {
        private readonly ILogBusiness _logBusiness;

        public LogController(ILogBusiness logBusiness)
        {
            _logBusiness = logBusiness;
        }

        [HttpGet]
        public IEnumerable<LogModel> Get()
        {

            return _logBusiness.Queries.Get();
        }
    }
}