using CasaDoCodigo.Models;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using System.Collections.Generic;
using System.Linq;

namespace CasaDoCodigo.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AplicationContext Context;

        public ProdutoRepository(AplicationContext context)
        {
            this.Context = context;
        }


        public IList<Produto> GetProdutos()
        {
            return Context.Set<Produto>().ToList();
        }


        public void SaveProdutos(List<Livro> Livros)
        {

            if (Livros == null)
            {
                foreach (var livro in Livros)
                {
                    Context.Set<Produto>().Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));
                }
                Context.SaveChanges();
            }
        }

    }
    public class Livro
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
