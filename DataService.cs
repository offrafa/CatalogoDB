using CasaDoCodigo.Models;
using CasaDoCodigo.Repository;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CasaDoCodigo
{
    class DataService : IDataService
    {
        private readonly AplicationContext Context;
        private readonly IProdutoRepository ProdutoRepository;

        public DataService(AplicationContext context, IProdutoRepository produtoRepository)
        {
            this.Context = context;
            this.ProdutoRepository = produtoRepository;
        }


        public void IncializaDb()
        {
            Context.Database.EnsureCreated();
            List<Livro> Livros = GetLivros();
            ProdutoRepository.SaveProdutos(Livros);

        }


        private static List<Livro> GetLivros()
        {
            var Json = File.ReadAllText("livros.json");
            var Livros = JsonConvert.DeserializeObject<List<Livro>>(Json);
            return Livros;
        }
    }


    

}
