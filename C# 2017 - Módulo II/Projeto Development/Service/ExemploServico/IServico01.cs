using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ExemploServico
{
   [ServiceContract]
    public interface IServico01
    {
        [OperationContract]
        string Mensagem();

        [OperationContract]
        int Somar(int x, int y);

        [OperationContract]
        Produto PromocaoDoDia();   
    }
}
