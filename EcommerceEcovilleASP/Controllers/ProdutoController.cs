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
            ViewBag.DataHora = DateTime.Now;
            return View(_produtoDAO.ListarProdutos());
        }


        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto produto)
        {
            _produtoDAO.CadastrarProduto(produto);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Editar(int? id)
        {
            return View(_produtoDAO.BuscarProdutoPeloId(id));
        }

        [HttpPost]
        public IActionResult Editar(Produto produto)
        {

            Produto p = _produtoDAO.BuscarProdutoPeloId(produto.ProdutoId);
            p.Nome = produto.Nome;
            p.Descricao = produto.Descricao;
            p.Preco = produto.Preco;
            p.Quantidade = produto.Quantidade;
            _produtoDAO.EditarProduto(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Remover(int? id)
        {
            if (id != null)
            {
            Produto p = _produtoDAO.BuscarProdutoPeloId(id);
                _produtoDAO.RemoverProduto(p);
            }
            return RedirectToAction("Index");
        }
    }
}