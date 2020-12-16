using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PracticaSofia.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Colocar Nombre del usuario")]
        [Display(Name = "Nombre del usuario")]
        public string Nombre { get; set; }
        [Required(ErrorMessage="Colocar Celular del usuario")]
        [Display(Name = "Celular del usuario")]
        public int Celular { get; set; }
        public List<Producto> Productos { get; set; }
    }
}