using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data.Entity
{
    public class AsistEntrenamiento : EntityBase
    {
        public bool Asistio { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int JugadorId { get; set; }
        public Jugador Jugador { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int EntrenamientoId { get; set; }
        public Jugador Entrenamiento { get; set; }

    }
}

