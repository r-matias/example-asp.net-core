using WebApi.Teste.Entities;
using WebApi.Teste.IRepository;

namespace WebApi.Teste.IBusiness
{
    public interface ILogBusiness
    {
        ILogQuery Queries { get; }

        void Save(Log entity);
    }
}
