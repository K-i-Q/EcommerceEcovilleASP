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
            ViewBag.Produtos = _produtoDAO.ListarProdutos();
            ViewBag.DataHora = DateTime.Now;
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
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Editar(int? id)
        {
            ViewBag.Produto = _produtoDAO.BuscarProdutoPeloId(id);
            return View();
        }

        [HttpPost]
        public IActionResult Editar(string txtNome, string txtDescricao,
                            string txtPreco, string txtQuantidade, int txtId)
        {

            Produto p = _produtoDAO.BuscarProdutoPeloId(txtId);
            p.Nome = txtNome;
            p.Descricao = txtDescricao;
            p.Preco = Convert.ToDouble(txtPreco.Replace("R$",""));
            p.Quantidade = Convert.ToInt32(txtQuantidade);
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