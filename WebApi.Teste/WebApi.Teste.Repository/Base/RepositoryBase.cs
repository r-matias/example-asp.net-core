using WebApi.Teste.Repository.Context;

namespace WebApi.Teste.Repository.Base
{
    public class RepositoryBase
    {
        private readonly WebApiTesteContext _context;

        public RepositoryBase(WebApiTesteContext context)
        {
            _context = context;
        }

        public WebApiTesteContext Context
        {
            get
            {
                return _context;
            }
        }
    }
}
