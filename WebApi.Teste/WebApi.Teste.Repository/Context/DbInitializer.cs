using System;
using WebApi.Teste.Entities;

namespace WebApi.Teste.Repository.Context
{
    public class DbInitializer
    {
        public static void Initialize(WebApiTesteContext context)
        {
            if (context.Database.EnsureCreated())
            {

                Log log = new Log("Testando o asp.net core");

                context.Logs.Add(log);

                context.SaveChanges();
            }
        }
    }
}
