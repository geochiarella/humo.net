using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using HumoServices.Dominio;

namespace HumoServices
{

    [ServiceContract]
    public interface IHumos
    {

        [OperationContract]
        [FaultContract(typeof(Aviso))]
        Humo Registrar(Humo o);

        [OperationContract]
        List<Humo> Listar();
    }

}
