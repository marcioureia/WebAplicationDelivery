using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCurso.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public string Image { get; set; }
        public bool Ativo { get; set; }

        public int CategoriaId { get; set; }
        public virtual CategoriaProduto Categoria { get; set; }
    }
}
