using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Events
{
    public interface IEventBus
    {
        Task Publish(List<IDomainEvent> events);

    }
}
