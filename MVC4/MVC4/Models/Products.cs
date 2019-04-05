using System.ComponentModel.DataAnnotations;

namespace MVC4.Models
{
    public enum Unitype
    {
        Botella,
        Metro,
        Litro,
        Caja
    }
    public enum StatusType
    {
        Activo, 
        Inactivo
    }

    public class Products
    {
        [Key]
        public int ProductsId { get; set; }

        [Required]
        public decimal Price { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        [Required]
        public Unitype Unit { get; set; }
        public StatusType Status { get; set; }
    }
}