using System;
using WebApi.Teste.Entities.Base;

namespace WebApi.Teste.Entities
{
    public class Log : EntityBase
    {
        public Log(string description)
        {
            Date = DateTime.Now;
        }

        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
