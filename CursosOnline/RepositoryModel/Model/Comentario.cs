using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryModel.Model
{
    public class Comentario
    {
        public int comentarioid { get; set; }
        public string Alumno { get; set; }
        public int Puntaje { get; set; }
        public string ComentarioTexto { get; set; }
        public int cursoid { get; set; }

        public Curso Curso { get; set; }
    }
}
