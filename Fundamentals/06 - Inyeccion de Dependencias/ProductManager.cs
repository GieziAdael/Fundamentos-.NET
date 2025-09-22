using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBasesCurso.Fundamentals._06___Inyeccion_de_Dependencias
{
    public class ProductManager
    { 
        private readonly ILabelService _labelService;
        public ProductManager (ILabelService labelService)
        {
            _labelService = labelService;
        }
        public void PrintLabel(ClassProduct product)
        {
            var label = _labelService.GenerateLabel(product);
            System.Console.WriteLine(label);
        }
    }
}
