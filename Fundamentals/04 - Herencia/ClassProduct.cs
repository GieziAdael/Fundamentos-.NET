using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBasesCurso.Fundamentals
{
    public class ClassProduct : IProduct
    {
        //Attributes
        public int Id { get; set; }
        [UpperCase]
        public string? Name { get; set; }
        [UpperCase]
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
        public DateTime CreateAt { get; set; }
        public Guid UniqueCode { get; set; }

        //Constructor ctor + tab + tab
        public ClassProduct(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
            CreateAt = DateTime.Now;
            UniqueCode = Guid.NewGuid();
        }

        //Methods
        public void ApplyDiscount(decimal percentage)
        {
            if (percentage > 0 && percentage <= 100)
            {
                var discount = (Price * percentage) / 100;
                Price -= discount;
            }
        }
        public virtual string GetProductFinal()
        {
            return $"Producto: {Name}, Precio: {Price:C}";
        }
    }

    class ServiceProduct : ClassProduct 
    { 
        public int DurationInDays { get; set; }
        public ServiceProduct(string name, decimal price, int duration) : base (name, price) 
        {
            this.DurationInDays = duration;
        }
        public override string GetProductFinal()
        {
            return $"{base.GetProductFinal()} - Duración: {DurationInDays} días";
        }
    }
}
