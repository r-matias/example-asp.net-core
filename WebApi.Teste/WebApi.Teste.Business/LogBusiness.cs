using System;
using WebApi.Teste.Entities;
using WebApi.Teste.IBusiness;
using WebApi.Teste.IRepository;

namespace WebApi.Teste.Business
{
    public class LogBusiness : ILogBusiness
    {
        public LogBusiness(ILogRepository logRepository)
        {
            Queries = logRepository;
            Command = logRepository;
        }

        public ILogQuery Queries { get; private set; }
        private ILogCommand Command { get; set; }

        public void Save(Log entity)
        {
            Command.Save(entity);
        }
    }
}
