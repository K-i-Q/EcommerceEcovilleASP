using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using Repository;
using System.Net;
using Newtonsoft.Json;

namespace EcommerceEcovilleASP.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioDAO _usuarioDAO;

        public UsuarioController(UsuarioDAO usuarioDAO)
        {
            _usuarioDAO = usuarioDAO;
        }

        // GET: Usuario
        public IActionResult Index()
        {
            return View(_usuarioDAO.ListarTodos());
        }

        // GET: Usuario/Details/5
        public IActionResult Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View(_usuarioDAO.BuscarPorId(id));
        }

        // GET: Usuario/Create
        public IActionResult Create()
        {
            Usuario user = new Usuario();
            if (TempData["Endereco"] != null)
            {
                string resultado = TempData["Endereco"].ToString();
                Endereco endereco = JsonConvert.DeserializeObject<Endereco>(resultado);
                user.Endereco = endereco;
            }
            //mostrar dados no formulário
            return View(user);
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("UsuarioId,Email,Senha,ConfirmacaoSenha,Endereco")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {

                if (_usuarioDAO.Cadastrar(usuario))
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", "Usuário já existe em nossa base de dados");
            }
            return View(usuario);
        }

        // GET: Usuario/Edit/5
        public IActionResult Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var usuario = _usuarioDAO.BuscarPorId(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }


        [HttpPost]
        public IActionResult BuscarCep(Usuario usuario)
        {
            string url = "https://viacep.com.br/ws/" + usuario.Endereco.Cep + "/json/";
            WebClient client = new WebClient();
            string resultado = client.DownloadString(url);
            //Endereco endereco = JsonConvert.DeserializeObject<Endereco>(resultado);
            TempData["Endereco"] = resultado;
            return RedirectToAction(nameof(Create));
        }
        // POST: Usuario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(long id, [Bind("UsuarioId,Email,Senha,ConfirmacaoSenha")] Usuario usuario)
        {
            if (id != usuario.UsuarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _usuarioDAO.EditarUsuario(usuario);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.UsuarioId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuario/Delete/5
        public IActionResult Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = _usuarioDAO.BuscarPorId(id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(long id)
        {
            _usuarioDAO.DeletarUsuario(id);
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(long id)
        {
            return _usuarioDAO.ExisteUsuario(id);
        }
    }
}
