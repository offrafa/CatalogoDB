﻿using CasaDoCodigo.Models;
using System.Collections.Generic;

namespace CasaDoCodigo.Repository
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> Livros);
        IList<Produto>GetProdutos();
    }
}