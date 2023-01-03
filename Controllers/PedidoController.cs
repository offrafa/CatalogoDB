using CasaDoCodigo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoRepository produtoRepository;

        public PedidoController(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Carrinho()
        {
            return View();
        }

        public IActionResult carrossel()
        {
            return View(produtoRepository.GetProdutos());
        }

        public IActionResult Resumo()
        {
            return View();
        }
    }
}
