﻿using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Nave
    {
        public int CodNave { get; set; }
        public string? DescripcionCorta { get; set; }
        public string? DescripcionLarga { get; set; }
    }
}
