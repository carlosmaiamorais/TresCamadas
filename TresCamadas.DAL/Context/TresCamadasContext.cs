using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TresCamadas.DAL.Maps;
using TresCamadas.Model;

namespace TresCamadas.DAL.Context
{
    public class TresCamadasContext : DbContext
    {
        public TresCamadasContext(DbContextOptions<TresCamadasContext> options) : base(options)
        {
            
        }

        //modelos

        public DbSet<Cliente> Clientes { get; set; }
        //public dbset<Produto> produtos {get;set;}
        //outra classe...

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configurar o mapeamento

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClienteMap());
            //e outras Entidades...
        }
    }
}
