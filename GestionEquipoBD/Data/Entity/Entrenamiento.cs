﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data.Entity
{
    public class Entrenamiento : EntityBase
    {
        public DateTime Fecha { get; set; }
        public string? Observacion { get; set; }
    }
}
