namespace Microservicio_Productos.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } //esta propiedad no la guarda en una columna de BD, ya que la busca en la otra tabla con la Guid CategoryId
    }
}
