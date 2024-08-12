using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data.Entity
{
    public class Jugador : EntityBase
    {
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(2, ErrorMessage = "Maximo 2 caracteres")]
        public string Edad { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Posicion { get; set; }
    }
}

