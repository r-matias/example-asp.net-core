using System.Collections.Generic;
using System.Linq;
using WebApi.Teste.Entities;
using WebApi.Teste.Entities.Model;
using WebApi.Teste.IRepository;
using WebApi.Teste.Repository.Base;
using WebApi.Teste.Repository.Context;

namespace WebApi.Teste.Repository
{
    public class LogRepository : RepositoryBase, ILogRepository
    {
        public LogRepository(WebApiTesteContext context) : 
            base(context)
        {
        }

        public IEnumerable<LogModel> Get()
        {
            return Context.Logs.Select(x => new LogModel
            {
                Date = x.Date,
                Description = x.Description
            }).ToList();
        }

        public void Save(Log entity)
        {
            Context.Logs.Add(entity);
            Context.SaveChanges();
        }
    }
}
