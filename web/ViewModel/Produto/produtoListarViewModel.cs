﻿using System.Collections.Generic;
using web.Models.Produto;

namespace web.ViewModel.Produto
{
    public class produtoListarViewModel
    {
        public IEnumerable<produto> produtos { get; set; }
        
        public IEnumerable<produtoCategoria> produtoCategorias { get; set; }
    }
}