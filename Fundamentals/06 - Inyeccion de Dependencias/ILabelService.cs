using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBasesCurso.Fundamentals._06___Inyeccion_de_Dependencias
{
    public interface ILabelService
    {
        string GenerateLabel(ClassProduct product);
    }
}
