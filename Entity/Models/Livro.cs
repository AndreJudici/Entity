using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int NumeroPaginas { get; set; }
        public double Valor { get; set; }
    }
}
