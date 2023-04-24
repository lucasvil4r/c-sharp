using System;
using System.Collections.Generic;
using System.Text;
using LojaNet.Models;
using System.Web;

namespace LojaNet.DAL
{
    //Cliente: Acesso a Dados
    // Data Access Layer
    public class ClienteDAL : IClienteDados
    {
		private Cliente cliente;
		private List<Cliente> lista;

		public void Alterar(Cliente cliente)
        {
            /*
            DbHelper.ExecuteNonQuery("ClienteAlterar",
               "@Id", cliente.Id,
               "@Nome", cliente.Nome,
               "@Email", cliente.Email,
               "@Telefone", cliente.Telefone
               );
            */
        }

        public void Excluir(string Id)
        {
            /*
            string arquivo = HttpContext.Current.Server.MapPath("~/App_Data/Cliente_" + Id + ".xml");
            Cliente cliente = ObterPorId(Id);
            SerializadorHelper.Serializar(arquivo, cliente);

            DbHelper.ExecuteNonQuery("ClienteExcluir", "@Id", Id);
            */
        }

        public void Incluir(Cliente cliente)
        {
            /*
             DbHelper.ExecuteNonQuery("ClienteIncluir",
                "@Id", cliente.Id,
                "@Nome", cliente.Nome,
                "@Email", cliente.Email,
                "@Telefone", cliente.Telefone
                );
            */
        }

		public Cliente ObterPorEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ApplicationException("O email deve ser informado");
            }

            /*
            Cliente cliente = null;
            using (var reader = DbHelper.ExecuteReader("ClienteObterPorEmail", "@Email", email))
            {
                if (reader.Read())
                {
                    cliente = ObterClienteReader(reader);

                }
            }
            */
            return cliente;
        }

        public Cliente ObterPorId(string id)
        {
            /*
            Cliente cliente = null;
            using (var reader = DbHelper.ExecuteReader("ClienteObterPorId", "@Id", id))
            {
                if (reader.Read())
                {
                    cliente = ObterClienteReader(reader);

                }
            }
            */
            return cliente;
        }

        public List<Cliente> ObterTodos()
        {
            /*
            var lista = new List<Cliente>();
            using (var reader = DbHelper.ExecuteReader("ClienteListar"))
            {
                while (reader.Read())
                {
                    Cliente cliente = ObterClienteReader(reader);

                    lista.Add(cliente);
                }
            }
            */
            return lista;
        }

        private static Cliente ObterClienteReader(System.Data.IDataReader reader)
        {
            var cliente = new Cliente();
            cliente.Id = reader["Id"].ToString();
            cliente.Nome = reader["Nome"].ToString();
            cliente.Email = reader["Email"].ToString();
            cliente.Telefone = reader["Telefone"].ToString();
            return cliente;
        }
    }
}
