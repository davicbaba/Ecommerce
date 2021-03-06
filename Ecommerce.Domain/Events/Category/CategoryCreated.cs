﻿using Ecommerce.Domain.ValueObject.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Events.Category
{
    public record CategoryCreated : IDomainEvent
    {
        public string Id { get; }
        public string Name { get; }
        public string Description { get; }


        public CategoryCreated(string id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }


        public string FullQualifiedEventName()
        {
            return "administrator.category.1.event.category.created";
        }
    }
}
