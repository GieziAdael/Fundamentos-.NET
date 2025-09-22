using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBasesCurso.Fundamentals._07___Metodos_Asincronos
{
    public class ClassProductRepository
    {
        public async Task<ClassProduct> GetProduct(int id)
        {
            //Obtener de una BD o de una llamada de una API externa
            System.Console.WriteLine("Esperando Producto..");
            await Task.Delay(2000);
            return new ClassProduct("Producto simulado", 500);
        }
    }
}
