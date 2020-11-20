using Ecommerce.Domain.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.EventBus
{
    public class MediatREventBus : IEventBus
    {
        private readonly IMediator _mediator;

        public MediatREventBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Publish(List<IDomainEvent> events)
        {
            foreach(var domainEvent in events)
            {
                await _mediator.Publish(domainEvent);
            }

        }
    }
}
