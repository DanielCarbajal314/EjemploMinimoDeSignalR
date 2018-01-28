using Microsoft.AspNet.SignalR;
using PruebaDeSignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PruebaDeSignalR.Controllers
{
    public class EnvioDeMensajesController : ApiController
    {

        public void Post(Mensaje Mensaje)
        {
            var hubDeMensajes = GlobalHost.ConnectionManager.GetHubContext<MensajesHub>();
            hubDeMensajes.Clients.All.RecibiMensaje(Mensaje);
        }

        public class Mensaje{
            public int Id { get; set; }
            public string Contenido { get; set; }
            public string Persona { get; set; }
        }
    }
}
