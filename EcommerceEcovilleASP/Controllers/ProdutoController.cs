using Domain;
using EcommerceEcovilleASP.DAL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;
using System;
using System.IO;

namespace EcommerceEcovilleASP.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoDAO _produtoDAO;
        private readonly CategoriaDAO _categoriaDAO;
        private readonly IHostingEnvironment _hosting;
        private string nomePastaParaSalvarImagem = "ecommerceImagens";
        public ProdutoController(ProdutoDAO produtoDAO, CategoriaDAO categoriaDAO, IHostingEnvironment hosting)
        {
            _produtoDAO = produtoDAO;
            _categoriaDAO = categoriaDAO;
            _hosting = hosting;
        }

        public IActionResult Index()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_produtoDAO.ListarTodos());
        }


        public IActionResult Cadastrar()
        {
            ViewBag.Categorias = new SelectList(_categoriaDAO.ListarTodos(), "CategoriaId", "Nome");
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto produto, long dropCategoria, IFormFile fupImagem)
        {
            ViewBag.Categorias = new SelectList(_categoriaDAO.ListarTodos(), "CategoriaId", "Nome");
            string arquivo;
            string caminho;

            if (ModelState.IsValid)
            {
                if (!_produtoDAO.ExisteProduto(produto.Nome))
                {
                    if (fupImagem != null)
                    {
                        //Path.GetFileName retorna o nome do arquivo independente das particularidades do sistema operacional
                        arquivo = Guid.NewGuid().ToString() + Path.GetExtension(fupImagem.FileName);// Path.GetFileName(fupImagem.FileName);
                                                                                                    //WebRootPath retornar caminho da aplicação de forma dinâmica
                                                                                                    //Path.Combine concatena de forma dinâmica independente das particularidades do s.o
                        caminho = Path.Combine(_hosting.WebRootPath, nomePastaParaSalvarImagem, arquivo);
                        fupImagem.CopyTo(new FileStream(caminho, FileMode.Create));
                        produto.Imagem = arquivo;
                    }
                    else
                    {
                        produto.Imagem = "s_imagem.jpg";
                    }
                    produto.Categoria = _categoriaDAO.BuscarPorId(dropCategoria);
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