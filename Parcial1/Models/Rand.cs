using System.ComponentModel.DataAnnotations;

namespace Parcial1.Models
{
    public class Rand
    {
        // resultado del numero random, en este caso no necesito otros valores
        [Display(Name = "Su número random es: ")]
        public int ResultRandom { get; set; }
    }
}
