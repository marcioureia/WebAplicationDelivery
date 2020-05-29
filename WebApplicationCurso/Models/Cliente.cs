using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCurso.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cellular { get; set; }
        public List<Endereco> Endereco { get; set; }

    }
}
