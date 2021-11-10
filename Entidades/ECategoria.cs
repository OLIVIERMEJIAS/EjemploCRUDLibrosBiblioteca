﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class ECategoria
    {
        string claveCategoria;
        string descripcion;

        public string ClaveCategoria { get; set; }
        public string Descripcion { get; set; }

        public ECategoria()
        {
            ClaveCategoria = string.Empty;
            Descripcion = string.Empty;
        }

        public ECategoria(string claCate, string desc)
        {
            ClaveCategoria = claCate;
            Descripcion = desc;
        }
    }
}
