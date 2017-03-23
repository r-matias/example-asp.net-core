using System.Collections.Generic;
using WebApi.Teste.Entities;
using WebApi.Teste.Entities.Model;

namespace WebApi.Teste.IRepository
{
    public interface ILogQuery
    {
        IEnumerable<LogModel> Get();
    }

    public interface ILogCommand
    {
        void Save(Log entity);
    }

    public interface ILogRepository : ILogQuery, ILogCommand
    {
    }
}
