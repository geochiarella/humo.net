using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace HumoServices.Dominio
{
    [DataContract]
    public class Humo
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Marca { get; set; }
        [DataMember]
        public int Cantidad { get; set; }
        [DataMember]
        public Tipo Tipo { get; set; }
    }
}