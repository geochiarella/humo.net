using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using HumoServices.Persistencia;
using HumoServices.Dominio;

namespace HumoServices
{

    public class Humos : IHumos
    {
        private HumoDAO humoDAO = null;
        private TipoDAO tipoDAO = null;

        private HumoDAO HumoDAO
        {
            get
            {
                if (humoDAO == null)
                    humoDAO = new HumoDAO();
                return humoDAO;
            }
        }

        private TipoDAO TipoDAO
        {
            get
            {
                if (tipoDAO == null)
                    tipoDAO = new TipoDAO();
                return tipoDAO;
            }
        }

        public Humo Registrar(Humo o)
        {
            int existeHumo = HumoDAO.Encontrar(o.Marca, o.Tipo.Codigo);
            Tipo tipoObtenido = TipoDAO.Obtener(o.Tipo.Codigo);
            Aviso aviso = new Aviso()
            {
                Codigo = 10,
                Mensaje = "El pucho \"" + o.Marca.ToUpper() + " : " + tipoObtenido.Nombre.ToUpper() + "\" ya existe"
            };
            if (existeHumo > 0)
                throw new FaultException<Aviso>(aviso, new FaultReason(aviso.Mensaje));

            Humo humoObtenido = HumoDAO.Crear(o);
            return humoObtenido;

        }

        public List<Humo> Listar()
        {
            return HumoDAO.ListarTodos().ToList();
        }
    }
}
