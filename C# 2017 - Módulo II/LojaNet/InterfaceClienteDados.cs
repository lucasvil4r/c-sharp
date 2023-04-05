using LojaNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaNet
{
    public interface InterfaceClienteDados
    {
        void Set(Cliente cliente);
        void Change(Cliente cliente);
        void Delete(Cliente cliente);
        List <Cliente> GetAll();
        Cliente GetById(int id);
        Cliente GetByEmail(String email);
    }
}
