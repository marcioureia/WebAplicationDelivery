using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCurso.Models.Enums
{
    public enum StatusPedido : int
    {
        Aberto = 1,
        Producao = 2,
        Pronto = 3,
        Despachado = 4,
        ACaminho = 5,
        Entregue = 6

    }
}
