using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3PSoft.LojaVirtual.Dominio.Entidades;

namespace _3PSoft.LojaVirtual.Dominio.Repositorio
{
    public class ProdutoRepositorio
    {
        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }
    }
}
