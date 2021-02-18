using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryModel.Model
{
    public class Precio
    {
        public int precioid { get; set; }
        public decimal PrecioActual { get; set; }
        public decimal Promocion { get; set; }
        public int cursoid { get; set; }

        public Curso Curso { get; set; }
    }
}
