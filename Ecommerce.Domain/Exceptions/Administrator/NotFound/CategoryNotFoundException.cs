using Ecommerce.Domain.ValueObject.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Exceptions.Administrator.NotFound
{
    public class CategoryNotFoundException : DomainException
    {
        public CategoryNotFoundException(CategoryId id): base (FormatMessage(id))
        {
        }
        private static string FormatMessage(CategoryId id)
        {
            return $"La categoria con identificador: {id} no existe";
        }
        public override string GetErrorCode()
        {
            return "category_not_found";
        }
    }
}
