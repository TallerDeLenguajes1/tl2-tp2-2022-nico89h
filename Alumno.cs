using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tl2_tp2_2022_nico89h
{
    internal class Alumno
    {
        private int Id { get; set; }
        private string Nombre { get; set; }=String.Empty;
        private string Apellido { get; set; } = String.Empty;
        private int Dni { get; set; }
        public int Curso { get; set; }
    }
}
