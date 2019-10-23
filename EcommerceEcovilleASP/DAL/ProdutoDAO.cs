﻿using EcommerceEcovilleASP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceEcovilleASP.DAL
{
    public class ProdutoDAO
    {

        //readonly para ser usado apenas no construtor e na declaração
        private readonly Context _context;
        public ProdutoDAO(Context context)
        {
            _context = context;
        }

        public void CadastrarProduto(Produto p)
        {
            _context.Produtos.Add(p);
            _context.SaveChanges();
        }

        public void EditarProduto(Produto p)
        {
            _context.Update(p);
            _context.SaveChanges();
        }
        public void RemoverProduto(Produto p)
        {
            _context.Produtos.Remove(p);
            _context.SaveChanges();
        }

        public Produto BuscarProdutoPeloId(int? id) => _context.Produtos.Find(id);

        public List<Produto> ListarProdutos() => _context.Produtos.ToList();
    }
}