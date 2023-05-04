using LojaNet.BLL;
using LojaNet.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LojaNet.Services
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "ConsultaCliente" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione ConsultaCliente.svc ou ConsultaCliente.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class ConsultaCliente : IConsultaCliente
    {
        public ClienteInfo ConsultarPorEmail(string chave, string email)
        {
            if (chave != "1234567890@!")
            {
                return null;
            }

            ClienteInfo clienteInfo = null;
            var dal = new ClienteDAL();
            var bll = new ClienteBLL(dal);
            var cliente = bll.ObterPorEmail(email);

            if (cliente == null) {
                return null;
            }
            else {
                clienteInfo = new ClienteInfo() {Nome = cliente.Nome, Email = cliente.Email, Telefone = cliente.Telefone };
            }
            return clienteInfo;
        }
    }
}
