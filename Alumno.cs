using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tl2_tp2_2022_nico89h
{
    internal class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }=String.Empty;
        public string Apellido { get; set; } = String.Empty;
        public int Dni { get; set; }
        public int Curso { get; set; }

        //inicio de constructores
        
        
        //inicio de constructor por defecto
        
        
        public Alumno()
        {
            //añadir un log para avisar que pueden ser null los strings
            this.Dni = 0;
            this.Curso = 0;
            this.Apellido = "";
            this.Nombre = "";
            this.Id = 0;
        }
        
        
        //inicio de constructor por sobrecarga
        
        public Alumno(int id, string nombre, string apellido, int dni, int curso)
        {
            //añadir un log para avisar que pueden ser null los strings
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Curso = curso;
        }




        //inicio de metodos

        public int getId()
        {
            return this.Id;
        }

        public string datos()
        {

            return  this.Id + "," + this.Nombre + "," + this.Apellido + "," + this.Dni + "," + this.Curso;
        }
        //inicio de el getter y setter



    }
}
