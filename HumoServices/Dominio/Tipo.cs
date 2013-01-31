using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace HumoServices.Dominio
{
    [DataContract]
    public class Tipo
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }
}