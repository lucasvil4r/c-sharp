using LojaNet.DAL;
using LojaNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaNet.BLL
{
    public class ClienteBLL : InterfaceClienteDados
    {
        public void Change(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Delete(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cliente GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Cliente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Set(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nome))
            {
                throw new ApplicationException("O nome deve ser informado");
            }

            if (string.IsNullOrEmpty(cliente.Id))
            {
                cliente.Id = Guid .NewGuid().ToString();
            }

            var dal = new ClienteDAL();
            dal.Set(cliente);
        }
    }
}
