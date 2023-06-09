﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseHerencia
{
    internal class Estudiante : Usuario
    {
        public string Matricula { get; set; }
        public decimal Edad { get; set; }

        public override string ToString()
        {
            return $"Cuenta: {Cuenta} | Pass: {Password} | Nombre: {Nombre} | Matricula: {Matricula} | Edad: {Edad}";
        }
    }
}
