using Domain;
using EcommerceEcovilleASP.DAL;
using Microsoft.AspNetCore.Mvc;
using System;

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
            return View(_produtoDAO.ListarTodos());
        }


        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                if (!_produtoDAO.ExisteProduto(produto.Nome))
                {
                    if (_produtoDAO.Cadastrar(produto))
                    {
                        return RedirectToAction("Index");
                    }
                    ModelState.AddModelError("", "Erro ao cadastrar");
                }
                ModelState.AddModelError("", "Esse produto já existe!");
                return View(produto);
            }
            return View(produto);
        }


        [HttpGet]
        public IActionResult Editar(int? id)
        {
            return View(_produtoDAO.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Editar(Produto produto)
        {

            Produto p = _produtoDAO.BuscarPorId(produto.ProdutoId);
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
                Produto p = _produtoDAO.BuscarPorId(id);
                _produtoDAO.RemoverProduto(p);
            }
            return RedirectToAction("Index");
        }
    }
}