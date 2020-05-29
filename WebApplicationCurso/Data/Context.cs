using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationCurso.Models
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationCurso.Models.Department> Department { get; set; }
        public DbSet<WebApplicationCurso.Models.CategoriaProduto> CategoriaProduto { get; set; }
        public DbSet<WebApplicationCurso.Models.Cliente> Cliente { get; set; }
        public DbSet<WebApplicationCurso.Models.Endereco> Endereco { get; set; }
        public DbSet<WebApplicationCurso.Models.PedidosItems> PedidosItems { get; set; }
        public DbSet<WebApplicationCurso.Models.Produto> Produto { get; set; }
        public DbSet<WebApplicationCurso.Models.User> User { get; set; }
        public DbSet<WebApplicationCurso.Models.SalesRecord> SalesRecord { get; set; }
        public DbSet<WebApplicationCurso.Models.Seller> Seller { get; set; }
    }
}
