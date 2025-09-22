using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBasesCurso.Fundamentals._05___Patron_Adaptador
{
    public class ProductAdapter
    {
        public static ProductDto ToDto(ClassProduct product)
        {
            return new ProductDto
            {
                Name = product.Name ?? "Sin nombre",
                Price = product.Price,
                Code = $"P-{product.Id}-{product.UniqueCode.ToString().Substring(0, 8)}"
            };
        }

    }
}
