using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBasesCurso.Fundamentals._06___Inyeccion_de_Dependencias
{
    public class ClassLabelService : ILabelService
    {
        public string GenerateLabel(ClassProduct product)
        {
            return $"{product.Name} - {product.Price:C} - Code: {product.GetType().Name}-{product.GetHashCode()}";
        }
    }
}
