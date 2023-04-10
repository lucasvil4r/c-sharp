﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaNet.Models;
namespace LojaNet.DAL
{
    public class ProdutoDAL : IProdutoDados
    {
        private LojaContext db = new LojaContext();

        public void Alterar(Produto produto)
        {
            var produtoOriginal = ObterPorId(produto.Id);
            if (produtoOriginal != null)
            {
                produtoOriginal.Nome = produto.Nome;
                produtoOriginal.Preco = produto.Preco;
                produtoOriginal.Estoque = produto.Estoque;
                db.SaveChanges();
            }
        }

        public void Excluir(string id)
        {
            var produto = ObterPorId(id);
            if (produto != null)
            {
                db.Produtos.Remove(produto);
                db.SaveChanges();
            }
        }

        public void Incluir(Produto produto)
        {
            db.Produtos.Add(produto);
            db.SaveChanges();
        }

        public Produto ObterPorId(string id)
        {
            var produto = db.Produtos.Where(m => m.Id == id).FirstOrDefault();
            return produto;

        }

        public List<Produto> ObterTodos()
        {
            return db.Produtos.ToList();
        }
    }
}
