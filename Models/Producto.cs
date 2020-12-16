using System.ComponentModel.DataAnnotations;

namespace PracticaSofia.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Colocar Nombre del Producto")]
        [Display(Name = "Nombre del Producto")]
        public string Nombre { get; set; }
        [Required(ErrorMessage="Colocar Link de la foto del producto")]
        [Display(Name = "Link de la foto del producto")]
        public string UrlFoto { get; set; }
        [Required(ErrorMessage="Colocar Descripcion del producto")]
        [Display(Name = "Descripcion del producto")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage="Colocar Precio del producto")]
        [Display(Name = "Precio del producto")]
        public double Precio { get; set; }
        [Required(ErrorMessage="Colocar Lugar de Compra del producto")]
        [Display(Name = "Lugar de Compra del producto")]
        public string LugarCompra { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}