using CsBasesCurso.Fundamentals;
using CsBasesCurso.Fundamentals._05___Patron_Adaptador;
using CsBasesCurso.Fundamentals._06___Inyeccion_de_Dependencias;
using CsBasesCurso.Fundamentals._07___Metodos_Asincronos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {


        //                                  Name,  Price
        var laptop = new ClassProduct("Laptop HP", 9900.50m);
        //System.Console.WriteLine(laptop.GetProductFinal());
        //                                  Name,    Price, Duracion Dias
        var soporte = new ServiceProduct("Soporte HP", 600, 50);
        //System.Console.WriteLine(soporte.GetProductFinal());

        var product = new ClassProduct("Mause Gamer", 325.99m);
        var productDto = ProductAdapter.ToDto(product);
        //System.Console.WriteLine($"{productDto.Name} - {productDto.Price:C} - Codigo: {productDto.Code}");

        //Inyeccion de dependencias
        ILabelService labelService = new ClassLabelService();
        var manager = new ProductManager(labelService);
        var monitor = new ClassProduct("Monitor", 3500);
        var instalacion = new ServiceProduct("Instalacion del monitor", 250, 30);
        //manager.PrintLabel(monitor);
        //manager.PrintLabel(instalacion);

        var firstProduct = await new ClassProductRepository().GetProduct(1);
        firstProduct.Description = "Esta es la descripcion del primer producto";
        AttributeProcessor.ApplyUpperCase(firstProduct);
        System.Console.WriteLine($"{firstProduct.Name} - {firstProduct.Price} - {firstProduct.Description}");

        System.Console.ReadKey();
    }
}