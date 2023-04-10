using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LojaNet.Models;
using LojaNet.DAL;

namespace LojaNet.Test
{
  
    [TestClass]
    public class PedidoUnitTest
    {
        [TestMethod]
        public void Incluir()
        {
            var pedido = new Pedido();
            pedido.Data = DateTime.Now;
            pedido.Cliente = new Cliente() { Id = "7860a3f3-c25d-4205-a89e-c8e7cd2397de", Nome = "José da Silva", Telefone = "3399849", Email = "jose@teste.com.br" };
            pedido.FormaPagamento = FormaPagamentoEnum.Dinheiro;
            pedido.Items = new List<Pedido.Item>();

            var item = new Pedido.Item();
            item.Produto = new Produto() { Id = "a39d817b-ec6b-4a20-b813-e8f7997ebd59", Nome = "Lápis", Preco = 100, Estoque = 0 };
            item.Quantidade = 3;
            item.Ordem = 1;
            item.Preco = 100;

            pedido.Items.Add(item);

            item = new Pedido.Item();
            item.Produto = new Produto() { Id = "ea164ec4-5574-4476-9776-534fec0ba8d2", Nome = "Caneta", Preco = 10, Estoque = 0 };
            item.Quantidade = 2;
            item.Ordem = 2;
            item.Preco = 10;

            pedido.Items.Add(item);


            var dal = new PedidoDAL();
            dal.Incluir(pedido);


        }


    }
}
