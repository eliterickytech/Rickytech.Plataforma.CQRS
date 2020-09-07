using MediatR;
using Rickytech.Plataforma.CQRS.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Rickytech.Plataforma.CQRS.EventsHandlers
{
    public class UsuarioNotificationHandlers : INotificationHandler<UsuarioActionNotification>
    {
        public Task Handle (UsuarioActionNotification usuarioActionNotification, CancellationToken  cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("O cliente {0} {1} foi {2} com sucesso", usuarioActionNotification.Nome, usuarioActionNotification.Sobrenome, usuarioActionNotification.Acao.ToString().ToLower());
            }); 
        }
    }
}
