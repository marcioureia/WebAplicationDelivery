using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCurso.Models.Enums;

namespace WebApplicationCurso.Models
{
    public class PedidosItems
    {
        public int Id { get; set; }
        public DateTime HoraPedido { get; set; }
        public Cliente Cliente { get; set; }
        public List<Produto> Produtos { get; set; }
        public  StatusPedido StatusPedido { get; set; }



    }
}
