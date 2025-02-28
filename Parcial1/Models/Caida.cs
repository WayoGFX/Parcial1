using System.ComponentModel.DataAnnotations;

namespace Parcial1.Models
{
    public class Caida
{
        // dato que se recibe
        public int Dato { get; set; }


        // resultado
        [Display(Name = "Su caída es de: ")]
        public string Result { get; set; }
        // Probando actualizacion
    }
}
