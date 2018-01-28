using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace PruebaDeSignalR.Hubs
{

    [HubName("Mensajes")]
    public class MensajesHub : Hub
    {
        public void EnviarMensajeATodos(string mensaje)
        {
            Clients.All.RecibiMensaje(mensaje);
        }
    }
}