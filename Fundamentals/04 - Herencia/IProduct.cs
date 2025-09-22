using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IProduct = InterfaceProduct
namespace CsBasesCurso.Fundamentals
{
    public interface IProduct
    {
        //Firma de las propiedades
        void ApplyDiscount(decimal percentage);
        string GetProductFinal();

    }
}
