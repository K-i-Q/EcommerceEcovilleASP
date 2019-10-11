using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceEcovilleASP.DAL;
using EcommerceEcovilleASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceEcovilleASP.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoDAO _produtoDAO;
        public ProdutoController(ProdutoDAO produtoDAO)
        {
            _produtoDAO = produtoDAO;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(string txtNome,string txtDescricao,string txtPreco,string txtQuantidade)
        {
            Produto p = new Produto
            {
                Nome = txtNome,
                Descricao = txtDescricao,
                Preco = Convert.ToDouble(txtPreco),
                Quantidade = Convert.ToInt32(txtQuantidade)

            };
            _produtoDAO.CadastrarProduto(p);
            return View();
        }
    }
}