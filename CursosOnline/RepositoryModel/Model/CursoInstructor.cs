using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryModel.Model
{
    public class CursoInstructor
    {
        public int Cursoid { get; set; }
        public Curso Curso { get; set; }

        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }
}
