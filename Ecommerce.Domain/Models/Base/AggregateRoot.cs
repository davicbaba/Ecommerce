using Ecommerce.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Models.Base
{
    public class AggregateRoot : AggregateEntity
    {
        public string tempid;

        private List<IDomainEvent> recordedDomainEvents = new List<IDomainEvent>();

        public List<IDomainEvent> PullDomainEvents()
        {
            List<IDomainEvent> domainEvents = recordedDomainEvents;

            domainEvents = new List<IDomainEvent>();

            return domainEvents;
        }


        public void Record(IDomainEvent domainEvent)
        {
            recordedDomainEvents.Add(domainEvent);
        }

    }

}
