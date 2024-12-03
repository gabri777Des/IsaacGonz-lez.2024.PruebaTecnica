using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaacGonzález._2024.EN
{
    public class Catego
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [RegularExpression("^[ a-zA-Z ]+$", ErrorMessage = "El nombre solo puede contener letras.")]
        public string Nombre { get; set; }
    }
}
